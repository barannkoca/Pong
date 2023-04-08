using UnityEngine;

public class LeftScore : MonoBehaviour
{
    public GameManager gameManager;

    private void OnCollisionEnter2D(Collision2D collision) {
        Ball ball = collision.gameObject.GetComponent<Ball>();

        if (ball != null)
        {
            gameManager.computerScores();
        }
    }
}
