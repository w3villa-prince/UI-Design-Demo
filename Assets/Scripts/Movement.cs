using UnityEngine;

public class Movement : MonoBehaviour
{
    public int mouseSensitivity = 400;
    private float yRotation = 0;
    public CharacterController controller;

    private float zRotation = 0;
    public Transform playerBody;
    public Transform cameraBody;

    public float speed = 40f;
    private Vector3 velocity;

    private void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    private void LateUpdate()
    {
        float mouseX = Input.GetAxis("Mouse X") * mouseSensitivity * Time.deltaTime;// take input in x
        float mouseY = Input.GetAxis("Mouse Y") * mouseSensitivity * Time.deltaTime;

        yRotation += mouseX;
        zRotation -= mouseY;
        zRotation = Mathf.Clamp(zRotation, -45f, 45f);

        playerBody.transform.localRotation = Quaternion.Euler(0f, yRotation, 0f);
        cameraBody.transform.localRotation = Quaternion.Euler(zRotation, yRotation, 0f);

        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");
        Vector3 move = transform.right * x + transform.forward * z;
        controller.Move(move * speed * Time.deltaTime);
    }
}
