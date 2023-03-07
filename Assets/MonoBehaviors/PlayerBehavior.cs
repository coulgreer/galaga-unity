using UnityEngine;

public class PlayerBehavior : MonoBehaviour
{
    public Rigidbody2D rb2D;
    public ShooterBehavior shooterBehavior;
    private float speed;
    private float moveHorizontal;

    void Start()
    {
        rb2D = gameObject.GetComponent<Rigidbody2D>();
        shooterBehavior = gameObject.GetComponent<ShooterBehavior>();
        Physics2D.gravity = Vector2.zero;

        speed = 2f;
    }

    void Update()
    {
        moveHorizontal = Input.GetAxisRaw("Horizontal");

        // Actions
        if (Input.GetKeyDown("space"))
        {
            SpriteRenderer renderer = gameObject.GetComponent<SpriteRenderer>();
            Vector2 size = renderer.bounds.size;
            Vector2 position = renderer.transform.position;
            shooterBehavior.shoot(position, size);
        }
    }

    void FixedUpdate()
    {
        // Movement
        if (moveHorizontal != 0f)
        {
            rb2D.velocity = new Vector2(moveHorizontal * speed, 0);
        }
        else
        {
            rb2D.velocity = new Vector2(0, 0);
        }
    }
}
