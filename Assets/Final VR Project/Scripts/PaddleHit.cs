using UnityEngine;

public class PaddleHit : MonoBehaviour
{
    public float hitForce = 8f;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Ball"))
        {
            Rigidbody rb = collision.gameObject.GetComponent<Rigidbody>();
            Vector3 direction = transform.forward;

            rb.velocity = direction * hitForce;
        }
    }
}