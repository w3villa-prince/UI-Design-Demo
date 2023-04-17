using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChanger : MonoBehaviour
{
    // Start is called before the first frame update
    public void OnclickVeiwW3villa()
    {
        // SceneManager.LoadSceneAsync("Demo");
        SceneManager.LoadSceneAsync("W3VillaDemoVRWith_Bake");
        // SceneManager.LoadScene("Demo");
    }
}
