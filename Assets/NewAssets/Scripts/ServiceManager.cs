using System.Collections.Generic;
using UnityEngine;

public class ServiceManager : MonoBehaviour
{
    public GameObject servicePrefabs;

    // public Vector3 postion = new Vector3(-3, 0, 0);
    public List<GameObject> servicePrefabGameObject;

    public GameObject subSerivceViewPrefab;

    // public Vector3 positionOfSubServicePrefab = new Vector3(0, -3, 0);
    public List<GameObject> subServiceViewPrefabGameObject;

    public void CreateService(Vector3 postion)
    {
        GameObject _serviceViewPrefabs = Instantiate(servicePrefabs, postion, Quaternion.identity);
        servicePrefabGameObject.Add(_serviceViewPrefabs);
    }

    public void CreateSubSerivcePrefabs(string name, string description, string imageLink, string actionLink, Vector3 positionOfSubService)
    {
        GameObject _SubServiewPrefab = Instantiate(subSerivceViewPrefab, positionOfSubService, subSerivceViewPrefab.transform.rotation);
        //Debug.Log(name + " " + description + " " + imageLink + " " + actionLink);
        _SubServiewPrefab.GetComponent<ServiceViewUpdate>().UpdateServiceSectionItemData(name, description, imageLink, actionLink);
        subServiceViewPrefabGameObject.Add(_SubServiewPrefab);
    }

    /* public GameObject twoSubServiceViewPrefab;
     public GameObject oneSubServiceViewPrefabs;

     public void CreateOneSubServiceView(string name, string description, string imageLink, string actionLink, Vector3 positionOfSubService)
     {
         GameObject _OneSubServiceViewPrefabs = Instantiate(oneSubServiceViewPrefabs, positionOfSubService, oneSubServiceViewPrefabs.transform.rotation);
         _OneSubServiceViewPrefabs.GetComponentInChildren<ServiceViewUpdate>().UpdateServiceSectionItemData(name, description, imageLink, actionLink);
     }

     public void CreateTwoSubSericeView()
     {
         GameObject _TwoSubServiceViewPrefabs = Instantiate(twoSubServiceViewPrefab, new Vector3(0, 0, 0), twoSubServiceViewPrefab.transform.rotation);
     }*/

    // Start is called before the first frame update
    private void Start()
    {
    }

    // Update is called once per frame
    private void Update()
    {
    }
}
