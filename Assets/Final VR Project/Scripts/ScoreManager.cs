using TMPro;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    public int playerScore = 0;
    public int enemyScore = 0;

    public TextMeshProUGUI playerText;
    public TextMeshProUGUI enemyText;

    public BallReset ballReset;

    void Start()
    {
        UpdateUI();
    }

    public void PlayerScores()
    {
        playerScore++;
        UpdateUI();
    }

    public void EnemyScores()
    {
        enemyScore++;
        UpdateUI();
    }

    void UpdateUI()
    {
        playerText.text = "Player: " + playerScore;
        enemyText.text = "Enemy: " + enemyScore;
    }
}