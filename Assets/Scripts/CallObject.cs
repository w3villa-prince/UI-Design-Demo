using UnityEngine;

public class CallObject : MonoBehaviour
{
    public Vector3 vector = new Vector3(1, 0, 0);

    private Vector3 rotation = Vector3.forward;
    //  public TextMeshProUGUI name;

    // Start is called before the first frame update
    private void Start()
    {
    }

    public void CubeCreate(string k)
    {
        GameObject cube = GameObject.CreatePrimitive(PrimitiveType.Cube);
        cube.transform.position = vector;
        vector = vector + new Vector3(1, 0, 0);
        cube.transform.Rotate(rotation * 10000 * Time.deltaTime);
        // name.SetText = "" + list[i];

        Debug.Log("String Print " + k);
        //  name.text = k;
    }

    // Update is called once per frame
    private void Update()
    {
    }
}
