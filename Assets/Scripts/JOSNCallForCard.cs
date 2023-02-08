using UnityEngine;

public class JOSNCallForCard : MonoBehaviour
{
    /// private PlayerCardUpdate PlayerCardUpdate;
    private CardListCreater CardListCreater;

    public TextAsset textJOSN;

    [System.Serializable]
    public class Card
    {
        public string name;
        public string age;
        public string about;
        public string description;
        public string link;
    }

    [System.Serializable]
    public class CardList
    {
        public Card[] card;
    }

    public CardList myCard = new CardList();

    // Start is called before the first frame update
    private void Start()
    {
        myCard = JsonUtility.FromJson<CardList>(textJOSN.text);
        // PlayerCardUpdate = GetComponent<PlayerCardUpdate>();
        CardListCreater = GetComponent<CardListCreater>();
        foreach (var child in myCard.card)
        {
            Debug.Log(child.name);
            Debug.Log(child.age);
            Debug.Log(child.about);
            Debug.Log(child.link);
            CardListCreater.CreateCardPrfabs(child.name, child.age, child.about, child.description, child.link);
            //  PlayerCardUpdate.CardUpdate(child.name, child.age, child.about, child.description, child.link);
        }
    }

    // Update is called once per frame
    private void Update()
    {
        // PlayerCardUpdate.CardUpdate(name, age, about, description, link);
    }
}
