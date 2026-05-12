using UnityEngine;

public class BallMovement : MonoBehaviour
{
    public float speed = 10f; 
    public float speedIncrease = 1f;
    public Rigidbody2D rb;
    public GameObject target;
    public Vector2 startPos;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {   
        startPos = transform.position;
        
        // Waits a few seconds to launch ball off of start
        Invoke("LaunchBall",2f);
    }

    // Used to get the ball to launch at random points
    void LaunchBall()
    {
        bool isRight = UnityEngine.Random.value >= 0.5f;

        float xVelocity = isRight ? 1f : -1f;

        float yVelocity = UnityEngine.Random.Range(0.5f,1f);

        if (Random.value < 0.5f)
        {
            xVelocity *= -1f;
        }

        Vector2 direction = new Vector2(xVelocity, yVelocity).normalized;

        rb.linearVelocity = direction * speed;
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        // Ball reset zones
        if (other.CompareTag("Red Goal"))
        {
            ResetBall();
        }

        if (other.CompareTag("Yellow Goal"))
        {
            ResetBall();
        }
    }

    void ResetBall()
    {
        // Reset position
        transform.position = startPos;

        // Reset speed
        speed = 10f;

        // Stop movement briefly
        rb.linearVelocity = Vector2.zero;

        // Launch ball again, Invoke is used hear to delay LaunchBall for 1sec
        Invoke("LaunchBall",2f);
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        speed += speedIncrease;

        rb.linearVelocity = rb.linearVelocity.normalized * speed;
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
