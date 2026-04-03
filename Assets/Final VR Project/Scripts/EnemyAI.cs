using UnityEngine;

public class EnemyAI : MonoBehaviour
{
    public Transform ball;
    public float speed = 5f;
    public float range = 1.5f;

    void Update()
    {
        if (ball == null) return;

        Vector3 target = transform.position;
        target.x = Mathf.Clamp(ball.position.x, -range, range);

        transform.position = Vector3.Lerp(transform.position, target, speed * Time.deltaTime);
    }
}