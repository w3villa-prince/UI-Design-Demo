using UnityEngine;

public class JOSNDataReadingWithServiceName : MonoBehaviour
{
    public TextAsset textJOSN;
    private ServiceManager _ServiceManagerList;

    [System.Serializable]
    public class SubService
    {
        public string name;
        public string imageLink;
        public string actionLink;
    }

    [System.Serializable]
    public class Services
    {
        public string serviceName;
        public SubService[] subService;
    }

    [System.Serializable]
    public class ServiceList
    {
        public Services[] services;
    }

    public ServiceList serivceList = new ServiceList();

    // Start is called before the first frame update
    private void Start()
    {
        serivceList = JsonUtility.FromJson<ServiceList>(textJOSN.text);
        _ServiceManagerList = GetComponent<ServiceManager>();

        int count = serivceList.services.Length;
        /* for (int i = 0; i < count; i++)
         {
             _serviceViewList.CreateService();
         }*/
        DataInflator();
    }

    private void DataInflator()
    {
        Vector3 position = new Vector3(-6, 0, 0);
        foreach (var subserivce in serivceList.services)
        {
            // i++;
            //Debug.Log("Sub service " + i);
            _ServiceManagerList.CreateService(position, subserivce.serviceName);

            //_subServicesViewList.GetComponent<SubServicesView>().cr;

            Vector3 postionOfSubService = position + new Vector3(-4, 0, 8);
            int i = 1;

            float rotateValue = 135;
            foreach (var view in subserivce.subService)
            {
                _ServiceManagerList.CreateSubSerivcePrefabs(view.name, " ", view.imageLink, view.actionLink, postionOfSubService, rotateValue);

                if (i % 2 != 0)
                {
                    postionOfSubService += new Vector3(12, 0, 0);
                    rotateValue = 45;
                }
                else
                {
                    postionOfSubService += new Vector3(-12, 0, 4);
                    rotateValue = 135;
                }

                i++;
                //  GetComponentInChildren<ServiceViewUpdate>().UpdateServiceSectionItemData(view.name, " ", view.imageLink, view.actionLink);
                // Debug.Log(view.name);
            }
            position += new Vector3(25, 0, 0);
        }
    }

    // Update is called once per frame
    private void Update()
    {
    }
}
