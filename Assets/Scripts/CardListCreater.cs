using UnityEngine;

public class CardListCreater : MonoBehaviour
{
    public GameObject gameObjectPrefabs;
    public Vector3 postion = new Vector3(0, 0, 0);

    private PlayerCardUpdate PlayerCardUpdate;

    private void Start()
    {
        PlayerCardUpdate = GetComponent<PlayerCardUpdate>();
    }

    public void CreateCardPrfabs(string name, string age, string about, string description, string link, string weblink)
    {
        GameObject textChanger = Instantiate(gameObjectPrefabs, postion, Quaternion.identity);
        Debug.Log("Prefabs Call COrrectly with position Change ...");
        // PlayerCardUpdate.CardUpdate(name, age, about, description, link);
        textChanger.GetComponent<PlayerCardUpdate>().CardUpdate(name, age, about, description, link, weblink);
        Debug.Log("Player card Update done.....");

        postion = postion + new Vector3(8, 0, 0);
    }
}

//PlayerCardUpdate.CardUpdate(child.name, child.age, child.about, child.description, child.link);
