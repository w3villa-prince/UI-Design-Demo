using TMPro;
using UnityEngine;

public class Service : MonoBehaviour
{
    public TextMeshPro serviceName;

    // Start is called before the first frame update
    private void Start()
    {
    }

    public void ServiceNameUpdate(string name)
    {
        serviceName.text = name;
    }

    // Update is called once per frame
    private void Update()
    {
    }
}
