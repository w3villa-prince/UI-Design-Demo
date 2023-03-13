using UnityEngine;

public class CamerHolder : MonoBehaviour
{
    [SerializeField] private Transform cameraPosition;

    // Start is called before the first frame update
    private void Start()
    {
    }

    // Update is called once per frame
    private void LateUpdate()
    {
        transform.position = cameraPosition.position + new Vector3(0f, 1.95f, 0f);
    }
}
