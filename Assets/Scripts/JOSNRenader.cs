using UnityEngine;

public class JOSNRenader : MonoBehaviour
{
    public TextAsset textJOSN;

    [System.Serializable]
    public class Player
    {
        public string name;
        public int health;
        public int man;
    }

    [System.Serializable]
    public class PlayerList
    {
        public Player[] player;
    }

    public PlayerList myPlayerList = new PlayerList();

    // Start is called before the first frame update
    private void Start()
    {
        myPlayerList = JsonUtility.FromJson<PlayerList>(textJOSN.text);
    }

    // Update is called once per frame
    private void Update()
    {
    }
}
