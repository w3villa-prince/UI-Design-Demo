using TMPro;
using UnityEngine;

public class ObstacleTextUpdate : MonoBehaviour
{
    public TextMeshProUGUI Text;
    // public string string1;

    // Start is called before the first frame update
    private void Start()
    {
    }

    public void TextUpdate(string k)
    {
        Text.text = k;
        Debug.Log(Text.text);
    }

    // Update is called once per frame

    private void Update()
    {
        // TextUpdate("hello");
        Debug.Log(Text.text);

        // TextUpdate(string1);
    }
}
