using UnityEngine;

public class Vector3LerpTesting : MonoBehaviour
{
    public Vector3 StartPoint;// = new Vector3(-10, -2, 0);
    public Vector3 EndPoint = new Vector3(10, 10, 0);
    public float speed = 1.0f;

    public MeshRenderer myMeshRenderer;

    private float desiredDuration = 3f;
    private float elapsedTime;

    [SerializeField]
    private AnimationCurve curve;

    private float journeyLength;

    // Start is called before the first frame update
    private void Start()
    {
        //i journeyLength = Vector3.Distance(StartPoint, EndPoint);

        StartPoint = transform.position;
    }

    // Update is called once per frame
    private void Update()
    {
        elapsedTime += Time.deltaTime;
        float percentageComplete = elapsedTime / desiredDuration;
        //  transform.position = Vector3.Lerp(StartPoint, EndPoint, percentageComplete);
        transform.position = Vector3.Lerp(StartPoint, EndPoint, curve.Evaluate(percentageComplete));
        myMeshRenderer.material.color = Color.Lerp(Color.red, Color.blue, percentageComplete);
    }
}
