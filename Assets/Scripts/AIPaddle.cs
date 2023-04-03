using UnityEngine;

public class AIPaddle : Paddle
{
    public Rigidbody2D ball;
    public float treshold = 0.0f;


    private void FixedUpdate() 
    {
        if (this.ball.velocity.x > 0.0f)
        {
            float targetY = Mathf.Clamp(ball.position.y, bottomBoundary + GetComponent<Renderer>().bounds.size.y / 2, topBoundary - GetComponent<Renderer>().bounds.size.y / 2);
            float distanceToTarget = targetY - transform.position.y;
            float direction = Mathf.Sign(distanceToTarget);
            float paddleMoveDistance = Mathf.Min(Mathf.Abs(distanceToTarget), speed * Time.deltaTime);
            transform.Translate(0, direction * paddleMoveDistance, 0);
        }

        else
        {
            float distanceToTarget = equal - transform.position.y;
            float direction = Mathf.Sign(distanceToTarget);
            float paddleMoveDistance = Mathf.Min(Mathf.Abs(distanceToTarget), speed * Time.deltaTime / 2);
            transform.Translate(0, direction * paddleMoveDistance, 0);
        }
    }
}
