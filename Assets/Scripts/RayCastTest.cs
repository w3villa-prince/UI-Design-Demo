using UnityEngine;
using UnityEngine.UI;

public class RayCastTest : MonoBehaviour
{
    [SerializeField] private LayerMask _layerMask;

    [SerializeField] private Image _hintsImage;

    // [SerializeField] private ActonBottonClass ActionButtonLInk;

    public float rayLength;

    private void FixedUpdate()
    {
        //layerMask2 = ~layerMask2;

        //layerMask = ~layerMask;

        RaycastHit hit;

        Debug.DrawRay(transform.position, transform.TransformDirection(Vector3.forward) * 10, Color.yellow);
        if (Physics.Raycast(transform.position, transform.forward, out hit, 10, _layerMask))
        {
            // Debug.DrawRay(transform.position, transform.TransformDirection(Vector3.forward) * hit.distance, Color.red);
            //Debug.Log("Hit object name " + hit.transform.name);

            if (hit.transform.CompareTag("Button"))
            {
                _hintsImage.color = Color.green;

                if (Input.GetMouseButtonUp(0))
                {
                    Debug.Log("OnCLick Dine ");

                    hit.collider.GetComponent<ActonBottonClass>().OnClickActionButon();
                    // ActionButtonLInk.OnClickActionButon();
                }

            }
            else
            {
                _hintsImage.color = Color.red;
            }

        }
    }
}
