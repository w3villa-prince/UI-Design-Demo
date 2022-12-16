using UnityEngine;

public class ManMenui : MonoBehaviour
{
    // Start is called before the first frame update
    public void ExitButton()
    {
        Application.Quit();
        Debug.Log("Game  Close! ");
    }

    public void StartGame()
    {
        Debug.Log("Game start CAll Done!");
    }

    public void Setting()
    {
        Debug.Log("Click Setting");
    }
}
