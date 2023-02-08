using UnityEngine;

public class ObjectCalling : MonoBehaviour
{
    //  public Mesh objectToCreate;
    public Vector3 vector = new Vector3(1, 0, 0);

    private Vector3 rotation = Vector3.forward;
    // public Rigidbody projectile;

    // Start is called before the first frame update
    private void Start()
    {
    }

    private void CubeCreate()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            GameObject cube = GameObject.CreatePrimitive(PrimitiveType.Cube);
            cube.transform.position = vector;
            vector = vector + new Vector3(1, 0, 0);
            cube.transform.Rotate(rotation * 10000 * Time.deltaTime);
        }
    }

    // Update is called once per frame
    private void Update()
    {
        //
        CubeCreate();
        // Ctrl was pressed, launch a projectile
        /*  if (Input.GetKeyDown("space"))
          {
              // Instantiate the projectile at the position and rotation of this transform
              Rigidbody clone;
              clone = Instantiate(projectile, transform.position, transform.rotation);

              // Give the cloned object an initial velocity along the current
              // object's Z axis
              clone.velocity = transform.TransformDirection(Vector3.forward * 10);
          }*/
    }
}
