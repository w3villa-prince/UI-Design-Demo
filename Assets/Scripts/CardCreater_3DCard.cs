using System.Collections.Generic;
using UnityEngine;

public class CardCreater_3DCard : MonoBehaviour
{
    public GameObject CardParentPrefab;

    public GameObject OneCardPrefabs;

    public Vector3 postion = new Vector3(0, 0, 0);
    public List<GameObject> cardsGameObject;
    private PlayerCardUpdate PlayerCardUpdate;

    public Vector3 UpdateZpostion;

    private void Start()
    {
        PlayerCardUpdate = GetComponent<PlayerCardUpdate>();
    }

    public void CreatecardParent()
    {
        GameObject textChanger = Instantiate(CardParentPrefab, postion, Quaternion.identity);
        Debug.Log("Prefabs Call COrrectly with position Change ...");

        cardsGameObject.Add(textChanger.GetComponent<TwoCardPrefabs>().card1);
        cardsGameObject.Add(textChanger.GetComponent<TwoCardPrefabs>().card2);

        // PlayerCardUpdate.CardUpdate(name, age, about, description, link);
        // textChanger.GetComponent<PlayerCardUpdate>().CardUpdate(name, age, about, description, link);
        Debug.Log("Player card Update done.....");

        // postion = postion + new Vector3(1, 3, 1);
        postion = postion + new Vector3(0, 0, 6);
        UpdateZpostion = postion;
    }

    public void CreatecardParentOneCard()
    {
        GameObject textChanger = Instantiate(OneCardPrefabs, postion, Quaternion.identity);
        Debug.Log("Prefabs Call COrrectly with position Change ...");

        cardsGameObject.Add(textChanger.GetComponent<TwoCardPrefabs>().card1);
        //  cardsGameObject.Add(textChanger.GetComponent<TwoCardPrefabs>().card2);

        // PlayerCardUpdate.CardUpdate(name, age, about, description, link);
        // textChanger.GetComponent<PlayerCardUpdate>().CardUpdate(name, age, about, description, link);
        Debug.Log("Player card Update done.....");

        // postion = postion + new Vector3(1, 3, 1);
        /// postion = postion + new Vector3(0, 0, 6);
        ///
        ///
        ///
        ///
        UpdateZpostion = UpdateZpostion + new Vector3(0, 0, 6);
    }

    private int count = 0;

    public void CardListTextUpdate(string name, string age, string about, string description, string link)
    {
        cardsGameObject[count].GetComponent<PlayerCardUpdate>().CardUpdate(name, age, about, description, link);
        count++;
    }

    // Start is called before the first frame update

    // Update is called once per frame
    private void Update()
    {
    }
}
