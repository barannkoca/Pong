using UnityEngine;

public class FoePaddle : Paddle
{
    private void FixedUpdate() 
    {
        if(Input.GetKey(KeyCode.UpArrow))
        {
            _rigidbody.MovePosition(transform.position + Vector3.up * speed * Time.deltaTime);
        }

        if(Input.GetKey(KeyCode.DownArrow))
        {
            _rigidbody.MovePosition(transform.position + Vector3.down * speed * Time.deltaTime);
        }
    }
}
