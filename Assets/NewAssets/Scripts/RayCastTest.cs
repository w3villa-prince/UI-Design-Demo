using UnityEngine;
using UnityEngine.SceneManagement;
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
            Debug.DrawRay(transform.position, transform.TransformDirection(Vector3.forward) * hit.distance, Color.red);
            //Debug.Log("Hit object name " + hit.transform.name);

            if (hit.transform.CompareTag("Button"))
            {
                _hintsImage.color = Color.green;

                if (Input.GetMouseButtonUp(0))
                {
                    Debug.Log("OnCLick Done ");

                    hit.collider.GetComponent<ActonBottonClass>().OnClickActionButon();
                    // ActionButtonLInk.OnClickActionButon();
                }
            }
            else if (hit.transform.CompareTag("W3villaBuilding"))
            {
                _hintsImage.color = Color.blue;
            }
            else if (hit.transform.CompareTag("W3villaOpenDoor"))
            {
                _hintsImage.color = Color.black;
                if (Input.GetMouseButtonUp(0))
                {
                    Debug.Log("On click Door Enter  ");
                    SceneManager.LoadScene("W3VillaDemoVRWith_Bake");
                }
            }
            else
            {
                _hintsImage.color = Color.red;
            }
        }
    }
}
