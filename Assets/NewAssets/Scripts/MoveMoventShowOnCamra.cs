using System.Collections;
using UnityEngine;

public class MoveMoventShowOnCamra : MonoBehaviour
{
    public int mouseSensitivity = 400;
    private float yRotation = 0;

    private float zRotation = 0;
    public Transform playerBody;
    public Transform cameraBody;

    // Start is called before the first frame update
    private void Start()
    {
    }

    // Update is called once per frame
    private void Update()
    {
        float mouseX = Input.GetAxis("Mouse X") * mouseSensitivity * Time.deltaTime;// take input in x
        float mouseY = Input.GetAxis("Mouse Y") * mouseSensitivity * Time.deltaTime;

        yRotation += mouseX;
        zRotation -= mouseY;
        zRotation = Mathf.Clamp(zRotation, -45f, 45f);

        playerBody.transform.localRotation = Quaternion.Euler(0f, yRotation, 0f);
        cameraBody.transform.localRotation = Quaternion.Euler(zRotation, yRotation, 0f);

        //  StartCoroutine(MoveShowInCamera(yRotation, zRotation));
        //  yRotation = Mathf.Clamp(yRotation, -90f, 90f);

        // cameraBody.transform.localRotation = Quaternion.Euler(zRotation, 0f, 0f);

        //  playerBody.transform.localPosition = Quaternion.Euler(0f, yRotation,0f);
        //transform.localRotation = Quaternion.Euler(0f, yRotation, 0f);

        /* yRotation += mouseX;

         zRotation += mouseY;
         //

         // transform.localRotation = Quaternion.Euler(zRotation, 0f, 0f);
         transform.localRotation = Quaternion.Euler(0f, yRotation, 0f);
         transform.Rotate(Vector3.right * mouseY);*//*
        yRotation += mouseY;

        //zRotation += mouseX;

        // zRotation += mouseY;
        //zRotation = Mathf.Clamp(zRotation, -90f, 90f);

        // transform.localRotation = Quaternion.Euler(zRotation, 0f, 0f);
        playerBody.Rotate(Vector3.right * yRotation);
        //transform.localRotation = Quaternion.Euler(0f, zRotation, 0f);
        playerBody.Rotate(Vector3.up * mouseX);*/
    }

    private IEnumerator MoveShowInCamera(float yRotation, float zRotation)
    {
        cameraBody.transform.localRotation = Quaternion.Euler(zRotation, yRotation, 0f);
        playerBody.transform.localRotation = Quaternion.Euler(0f, yRotation, 0f);

        yield return new WaitForSeconds(0);
    }
}
