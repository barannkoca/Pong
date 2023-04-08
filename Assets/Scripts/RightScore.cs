using UnityEngine;

public class RightScore : MonoBehaviour
{
    public GameManager gameManager;

    private void OnCollisionEnter2D(Collision2D collision) {
        Ball ball = collision.gameObject.GetComponent<Ball>();

        if (ball != null)
        {
            gameManager.playerScores();
        }
    }
}
