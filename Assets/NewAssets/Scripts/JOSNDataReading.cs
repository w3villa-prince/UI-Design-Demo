using UnityEngine;

public class JOSNDataReading : MonoBehaviour
{
    public TextAsset textJOSN;

    // private ServiceView _serviceViewList;
    // public GameObject _subServicesViewList;
    //  public GameObject _subServicesViewList
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
        public SubService[] subService;
    }

    [System.Serializable]
    public class SubServiceList
    {
        public Services[] services;
    }

    public SubServiceList serivceList = new SubServiceList();

    // Start is called before the first frame update
    private void Start()
    {
        serivceList = JsonUtility.FromJson<SubServiceList>(textJOSN.text);
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
            _ServiceManagerList.CreateService(position);

            //_subServicesViewList.GetComponent<SubServicesView>().cr;

            Vector3 postionOfSubService = position + new Vector3(0, 0, 4);
            int i = 1;
            foreach (var view in subserivce.subService)
            {
                _ServiceManagerList.CreateSubSerivcePrefabs(view.name, " ", view.imageLink, view.actionLink, postionOfSubService);

                if (i % 2 != 0)
                {
                    postionOfSubService += new Vector3(4, 0, 0);
                }
                else
                {
                    postionOfSubService += new Vector3(-4, 0, 4);
                }

                i++;
                //  GetComponentInChildren<ServiceViewUpdate>().UpdateServiceSectionItemData(view.name, " ", view.imageLink, view.actionLink);
                // Debug.Log(view.name);
            }
            position += new Vector3(10, 0, 0);
        }
    }

    // Update is called once per frame
    private void Update()
    {
    }
}
