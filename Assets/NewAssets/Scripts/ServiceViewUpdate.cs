using System.Collections;
using TMPro;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.UI;

public class ServiceViewUpdate : MonoBehaviour
{
    private void Start()
    {
        //  ServiceViewDataUpdatebyJOSN("W3villa ", " hello anyOne are Reday", "https://jsonformatter.org/", "https://jsonformatter.org/");
    }

    // Update is called once per frame
    private void Update()
    {
    }

    public TextMeshProUGUI Name;
    public TextMeshProUGUI Description;
    public RawImage Image;
    public ActonBottonClass ActionButton;
    public Texture2D texture;

    public void ServiceViewDataUpdatebyJOSN(string name, string description, string imageLink, string actionLink)
    {
        Name.text = name;
        Description.text = description;
        ActionButton.buttonText.text = actionLink;
        StartCoroutine(ImageDownloader(imageLink));
        Image.texture = texture;
    }

    private IEnumerator ImageDownloader(string imagelink)
    {
        UnityWebRequest www = UnityWebRequestTexture.GetTexture(imagelink);

        yield return www.SendWebRequest();
        if (www.result != UnityWebRequest.Result.Success)
            Debug.Log(www.error);
        else
        {
            texture = DownloadHandlerTexture.GetContent(www);

            Image.texture = texture;
        }
    }

    // Start is called before the first frame update
}
