using UnityEngine;

public class BallReset : MonoBehaviour
{
    public Transform servePoint;
    public float serveForce = 5f;

    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        ResetBall();
    }

    public void ResetBall()
    {
        transform.position = servePoint.position;

        rb.velocity = Vector3.zero;
        rb.angularVelocity = Vector3.zero;

        Vector3 dir = new Vector3(Random.Range(-0.3f, 0.3f), 0, 1).normalized;
        rb.AddForce(dir * serveForce, ForceMode.Impulse);
    }
}