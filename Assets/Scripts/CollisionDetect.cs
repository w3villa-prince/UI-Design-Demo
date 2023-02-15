using UnityEngine;

public class CollisionDetect : MonoBehaviour
{
    // Start is called before the first frame update
    private void Start()
    {
    }

    private void OnTiggerEnter(Collision collision)
    {
        /* Debug.Log("COllisionDetected Now ");
         if (collision.gameObject.CompareTag("Boundary"))
         {
             Debug.Log("Out of Boundary limit Action ");
         }
         if (collision.gameObject.CompareTag("Ground"))
         {
             Debug.Log(" READY TO ACTION ");
         }*/

        if (collision.gameObject.CompareTag("Player"))
        {
            Debug.Log("Collision detect");
        }
    }

    // Update is called once per frame
    private void Update()
    {
    }
}
