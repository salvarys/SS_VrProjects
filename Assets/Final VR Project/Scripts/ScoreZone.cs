using UnityEngine;

public class ScoreZone : MonoBehaviour
{
    public bool isPlayerSide;

    public ScoreManager scoreManager;
    public BallReset ballReset;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Ball"))
        {
            if (isPlayerSide)
                scoreManager.EnemyScores();
            else
                scoreManager.PlayerScores();

            ballReset.ResetBall(); 
        }
    }

}