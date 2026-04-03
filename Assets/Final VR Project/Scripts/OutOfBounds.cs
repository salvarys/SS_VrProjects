using UnityEngine;

public class OutOfBounds : MonoBehaviour
{
    public BallReset ballReset;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Ball"))
        {
            ballReset.ResetBall();
        }
    }
}