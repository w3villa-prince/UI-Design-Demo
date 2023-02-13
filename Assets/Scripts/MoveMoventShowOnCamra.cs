using UnityEngine;

public class MoveMoventShowOnCamra : MonoBehaviour
{
    public int mouseSensitivity = 100;
    private float yRotation = 0;

    private float zRotation = 0;
    public Transform playerBody;

    // Start is called before the first frame update
    private void Start()
    {
    }

    // Update is called once per frame
    private void Update()
    {
        float mouseX = Input.GetAxis("Mouse X") * mouseSensitivity * Time.deltaTime;// take input in x
        float mouseY = Input.GetAxis("Mouse Y") * mouseSensitivity * Time.deltaTime;
        /* yRotation += mouseX;

         zRotation += mouseY;
         //zRotation = Mathf.Clamp(zRotation, -90f, 90f);

         // transform.localRotation = Quaternion.Euler(zRotation, 0f, 0f);
         transform.localRotation = Quaternion.Euler(0f, yRotation, 0f);
         transform.Rotate(Vector3.right * mouseY);*/
        yRotation += mouseY;

        yRotation = Mathf.Clamp(yRotation, -90f, 90f);

        //zRotation += mouseX;

        // zRotation += mouseY;
        //zRotation = Mathf.Clamp(zRotation, -90f, 90f);

        // transform.localRotation = Quaternion.Euler(zRotation, 0f, 0f);
        transform.localRotation = Quaternion.Euler(yRotation, 0f, 0f);
        //transform.localRotation = Quaternion.Euler(0f, zRotation, 0f);
        playerBody.Rotate(Vector3.up * mouseX);
    }
}
