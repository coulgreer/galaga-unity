using UnityEngine;

public class ShooterBehavior : MonoBehaviour
{
    public GameObject projectile;
    [SerializeField] public float speed;

    private GameObject clone;
    private Rigidbody2D rb;

    // Start is called before the first frame update
    void Start()
    {
        projectile.SetActive(false);
        clone = Instantiate(projectile);
        rb = clone.GetComponent<Rigidbody2D>();
    }

    public void shoot(Vector3 parentPos, Vector3 parentSize)
    {
        Vector2 projectileSize = gameObject
          .GetComponent<SpriteRenderer>()
          .size;
        int magnitude = parentPos.x < 0 ? -1 : 1;
        float projectileX =
          (parentPos.x + magnitude * parentSize.x / 2)
          - (magnitude * projectileSize.x / 2);
        float projectileY = parentPos.y + parentSize.y;

        clone.transform.position = new Vector2(projectileX, projectileY);
        clone.SetActive(true);
        rb.velocity = new Vector2(0, speed);
    }
}
