using UnityEngine;

public class CallListOfObject : MonoBehaviour
{
    // private  CallObject CallObject;
    public string[] list = { "A ", " B", "C", "D " };

    public Vector3 vector = new Vector3(0, 0, 0);

    private Vector3 rotation = Vector3.forward;
    public GameObject ObstaclePrefab;
    private GameObject gameObject;
    // public TextMeshProUGUI name;

    // Start is called before the first frame update

    private void Start()
    {
        //CallObject = GetComponent<CallObject>();
        for (int i = 0; i < (list.Length); i++)
        {
            // CubeCreate(i);
            // Instantiate(ObstaclePrefab, new Vector3(0, 0, 0), Quaternion.identity);

            //CallObject.CubeCreate(list[i]);
            ObstaclePrefab.GetComponent<ObstacleTextUpdate>().TextUpdate(list[i]);
            GameObject textChanger = Instantiate(ObstaclePrefab, vector, Quaternion.identity);

            vector = vector + new Vector3(2, 0, 0);

            Debug.Log("Calling...." + i);
            Debug.Log("String Print " + list[i]);
            // yield return new WaitForSeconds(5f);
        }
    }

    private void CubeCreate(int i)
    {
        // GameObject cube = GameObject.CreatePrimitive(PrimitiveType.Cube);
        // cube.transform.position = vector;
        vector = vector + new Vector3(2, 0, 0);
        //cube.transform.Rotate(rotation * 10000 * Time.deltaTime);

        // GetComponent<ObstacleTextUpdate>().TextUpdate(list[i]);

        Debug.Log("String Print " + list[i]);
    }

    // Update is called once per frame
    private void Update()
    {
    }
}
