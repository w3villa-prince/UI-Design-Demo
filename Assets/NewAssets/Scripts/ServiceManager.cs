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

    public void CreateService(Vector3 postion, string name)
    {
        GameObject _serviceViewPrefabs = Instantiate(servicePrefabs, postion, Quaternion.identity);
        servicePrefabGameObject.Add(_serviceViewPrefabs);
        _serviceViewPrefabs.GetComponentInChildren<Service>().ServiceNameUpdate(name);
    }

    public void CreateService(Vector3 postion)
    {
        GameObject _serviceViewPrefabs = Instantiate(servicePrefabs, postion, Quaternion.identity);
        servicePrefabGameObject.Add(_serviceViewPrefabs);
    }

    public void CreateSubSerivcePrefabs(string name, string description, string imageLink, string actionLink, Vector3 positionOfSubService, float rotateValue)
    {
        GameObject _SubServiewPrefab = Instantiate(subSerivceViewPrefab, positionOfSubService, Quaternion.Euler(subSerivceViewPrefab.transform.rotation.x, subSerivceViewPrefab.transform.rotation.y - rotateValue, subSerivceViewPrefab.transform.rotation.z));
        //Debug.Log(name + " " + description + " " + imageLink + " " + actionLink);
        _SubServiewPrefab.GetComponent<ServiceViewUpdate>().UpdateServiceSectionItemData(name, description, imageLink, actionLink);
        subServiceViewPrefabGameObject.Add(_SubServiewPrefab);
    }

    // Start is called before the first frame update
    private void Start()
    {
    }

    // Update is called once per frame
    private void Update()
    {
    }
}
