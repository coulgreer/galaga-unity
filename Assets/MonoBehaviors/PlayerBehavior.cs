using UnityEngine;

public class PlayerBehavior : MonoBehaviour
{
  Rigidbody2D rb2D;

  private float speed;
  private float moveHorizontal;

  void Start()
  {
    rb2D = gameObject.GetComponent<Rigidbody2D>();
    Physics2D.gravity = Vector2.zero;

    speed = 2f;
  }

  void Update()
  {
    moveHorizontal = Input.GetAxisRaw("Horizontal");
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

    // Actions
    if(Input.GetKeyDown("space")) {
      
    }
  }
}
