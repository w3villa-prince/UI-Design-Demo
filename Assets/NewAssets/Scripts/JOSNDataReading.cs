using UnityEngine;

public class JOSNDataReading : MonoBehaviour
{
    public TextAsset textJOSN;

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
    }

    // Update is called once per frame
    private void Update()
    {
    }
}
