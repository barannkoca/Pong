using UnityEngine;

public class Paddle : MonoBehaviour
{
    public float speed = 1.0f;
    protected Rigidbody2D _rigidbody;

    // screen boundaries
    protected float topBoundary;
    protected float bottomBoundary;
    protected float equal;

    private void Awake() {
        _rigidbody = GetComponent<Rigidbody2D>();
    }

    // initialize game
    void Start()
    {
        // calculate screen boundaries
        topBoundary = Camera.main.ScreenToWorldPoint(new Vector3(0, Screen.height, 0)).y;
        bottomBoundary = Camera.main.ScreenToWorldPoint(new Vector3(0, 0, 0)).y;
        equal = (topBoundary + bottomBoundary) / 2;
    }
}
