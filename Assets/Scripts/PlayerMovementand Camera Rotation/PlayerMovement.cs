using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Transform orientation;
    public float moveSpeed;
    private float horitonalInput;
    private float verticalInput;
    private Vector3 moveDirction;
    private Rigidbody rd;

    // Start is called before the first frame update
    private void Start()
    {
        rd = GetComponent<Rigidbody>();
        rd.freezeRotation = true;
    }

    private void FixedUpdate()
    {
        playerMove();
    }

    private void MyInput()
    {
        horitonalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");
    }

    // Update is called once per frame
    private void Update()
    {
        MyInput();
    }

    private void playerMove()
    {
        moveDirction = orientation.forward * verticalInput + orientation.right * horitonalInput;
        rd.AddForce(moveDirction.normalized * moveSpeed * 2f, ForceMode.Force);
    }
}
