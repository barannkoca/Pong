using UnityEngine;

public class PlayerPaddle : Paddle
{
    private void FixedUpdate() 
    {
        if(Input.GetKey(KeyCode.W))
        {
            _rigidbody.MovePosition(transform.position + Vector3.up * speed * Time.deltaTime);
        }

        if(Input.GetKey(KeyCode.S))
        {
            _rigidbody.MovePosition(transform.position + Vector3.down * speed * Time.deltaTime);
        }
    }
}
