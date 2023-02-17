using TMPro;
using UnityEngine;



public class ActonBottonClass : MonoBehaviour
{
    public string _link;
    public TextMeshProUGUI buttonText;


    // Start is called before the first frame update
    private void Start()
    {


    }



    // Update is called once per frame
    private void Update()
    {
    }

    public void OnClickActionButon()
    {
        Debug.Log("ClickActionButon");
        Application.OpenURL(_link);
    }



    void OnLinkByURL()
    {
        Debug.Log("Get Link action");

        Debug.Log(_link);
        Application.OpenURL(_link);
    }
}
