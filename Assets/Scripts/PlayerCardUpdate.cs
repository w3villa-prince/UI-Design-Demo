using System.Collections;
using TMPro;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.UI;

public class PlayerCardUpdate : MonoBehaviour
{
    public TextMeshProUGUI Name;
    public TextMeshProUGUI Age;
    public TextMeshProUGUI About;
    public TextMeshProUGUI Description;
    public RawImage PlayerImage;
    public Texture2D texture;
    public ActonBottonClass ActionBtn;

    //  public  ImageConversion image;

    // Start is called before the first frame update
    private void Start()
    {
        //CardUpdate("XYZ", "19", "Gamer", " hello word ", "https://www.shutterstock.com/image-photo/mountains-under-mist-morning-amazing-260nw-1725825019.jpg");
    }

    public void CardUpdate(string name, string age, string about, string description, string link, string weblink)
    {
        Name.text = name;
        Age.text = age;
        About.text = about;
        Description.text = description;

        // = weblink;

        ActionBtn._link = weblink;
        ActionBtn.buttonText.text = weblink;
        //layerImage.color = Color.red;
        StartCoroutine(ImageDownloader(link));

        PlayerImage.texture = texture;
    }

    private IEnumerator ImageDownloader(string link)
    {
        UnityWebRequest www = UnityWebRequestTexture.GetTexture(link);

        yield return www.SendWebRequest();
        if (www.result != UnityWebRequest.Result.Success)
            Debug.Log(www.error);
        else
        {
            texture = DownloadHandlerTexture.GetContent(www);

            PlayerImage.texture = texture;
        }
    }

    // Update is called once per frame
    private void Update()
    {
    }
}
