using UnityEngine;

public class ColorLerpTesting : MonoBehaviour
{
    [SerializeField] private Color lerpedColor;

    public Color redColor, blueColor;
    [SerializeField] private Color currentColor;
    [SerializeField] private MeshRenderer myRenderer;

    public Material Material;

    // Start is called before the first frame update
    private void Start()
    {
        // myRenderer = GetComponent<MeshRenderer>();

        // myRenderer.material.color = redColor;

        //// myRenderer.material.color = lerpedColor;

        /* lerpedColor = GetComponent<MeshRenderer>().material.color;

         GetComponent<MeshRenderer>().material.color = Color.white;

         lerpedColor = Color.white*/

        // currentColor = redColor;

        // Material.color = lerpedColor;
    }

    // Update is called once per frame
    private void Update()
    {
        /* if (Input.GetKeyDown(KeyCode.Space))
         {
             Debug.Log("OnEnterSpace");
             if (currentColor == redColor)
             {
                 currentColor = blueColor;
             }
             else
             {
                 currentColor = redColor;
             }
         }

         myRenderer.material.color = Color.Lerp(myRenderer.material.color, currentColor, 0.01f);*/

        /* if (Input.GetKeyDown(KeyCode.Space))
         {
             if (lerpedColor == Color.white)
             {
                 Debug.Log("Enter White ");

                 // lerpedColor = Color.Lerp(Color.white, Color.red, Mathf.PingPong(Time.time, 1));
                 lerpedColor = Color.Lerp(Color.white, Color.red, .1f);
                 Debug.Log("Color Change red ");
             }
             else if (lerpedColor == Color.red)
             {
                 Debug.Log("Enter Red");
                 //  lerpedColor = Color.Lerp(Color.red, Color.blue, Mathf.PingPong(Time.time, 1));
                 lerpedColor = Color.Lerp(Color.red, Color.blue, .1f);
                 Debug.Log("Color Change  Blue");
             }
             else
             {
                 Debug.Log("Enter  Blue");
                 // lerpedColor = Color.Lerp(Color.blue, Color.white, Mathf.PingPong(Time.time, 1));
                 lerpedColor = Color.Lerp(Color.blue, Color.white, .1f);
                 Debug.Log("Color Change White");
             }
         }*/

        lerpedColor = Color.Lerp(Color.white, Color.red, Time.deltaTime * 1f);
    }
}
