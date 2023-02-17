using UnityEngine;

public class JOSNCall_3DCard : MonoBehaviour
{
    private CardCreater_3DCard CardListCreater;

    public TextAsset textJOSN;
    /// private PlayerCardUpdate PlayerCardUpdate;

    [System.Serializable]
    public class Card
    {
        public string name;
        public string age;
        public string about;
        public string description;
        public string link;
        public string weblink;
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
        CardListCreater = GetComponent<CardCreater_3DCard>();

        int count = myCard.card.Length;
        Debug.Log(count);

        if (count % 2 == 0)
        {
            for (int i = 0; i < count; i += 2)
            {
                CardListCreater.CreatecardParent();
                Debug.Log(i);
            }
        }
        else
        {
            for (int i = 0; i < count - 1; i += 2)
            {
                CardListCreater.CreatecardParent();
                Debug.Log(i);
            }

            CardListCreater.CreatecardParentOneCard();
        }
        /**/

        foreach (var child in myCard.card)

        {
            //  Debug.Log(child.name);
            // Debug.Log(child.age);
            // Debug.Log(child.about);
            // Debug.Log(child.link);
            // Debug.Log(child.weblink);

            Debug.Log("JOSN Read Done.....");
            CardListCreater.CardListTextUpdate(child.name, child.age, child.about, child.description, child.link, child.weblink);

            // CardListCreater.CreateCardPrfabs(child.name, child.age, child.about, child.description, child.link);
        }
    }
}
