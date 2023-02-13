using UnityEngine;

public class Player : MonoBehaviour
{
    // Start is called before the first frame update

    [SerializeField] private Color lerpedColor = Color.white;

    private void Start()
    {
    }

    // Update is called once per frame
    private void Update()
    {
        lerpedColor = Color.Lerp(Color.white, Color.black, Time.deltaTime * 100f);
    }
}
