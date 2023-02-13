using UnityEngine;

public class MathfLerpTesting : MonoBehaviour
{
    // Start is called before the first frame update
    // animate the game object from -1 to +1 and back
    public float minimum = -1.0F;

    public float maximum = 1.0F;

    // starting value for the Lerp
    private static float t = 0.0f;

    private void Update()
    {
        // animate the position of the game object...
        transform.position = new Vector3(Mathf.Lerp(minimum, maximum, t), 0, 0);

        // .. and increase the t interpolater
        t += 0.5f * Time.deltaTime;

        // now check if the interpolator has reached 1.0
        // and swap maximum and minimum so game object moves
        // in the opposite direction.
        if (t > 1.0f)
        {
            float temp = maximum;
            maximum = minimum;
            minimum = temp;
            t = 0.0f;
        }
    }
}
