using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    private int _playerScore;
    private int _computerScore;
    public Ball ball;
    public Text playerScoreText;
    public Text computerScoreText;

    public void playerScores()
    {
        _playerScore++;
        this.playerScoreText.text = _playerScore.ToString();
        this.ball.resetPosition();
    }

    public void computerScores()
    {
        _computerScore++;
        this.computerScoreText.text = _computerScore.ToString();
        this.ball.resetPosition();
    }
}
