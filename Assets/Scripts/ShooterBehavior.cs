using UnityEngine;

public class ShooterBehavior : MonoBehaviour
{
    public GameObject projectile;
    [SerializeField] public float speed;

    private ProjectileManager projectileManager;

    // Start is called before the first frame update
    void Start()
    {
        projectile.SetActive(false);
        projectileManager = new ProjectileManager(projectile);
    }

    public void shoot(Vector3 parentPos, Vector3 parentSize)
    {
        GameObject firedProjectile = projectileManager.GetInactiveProjectile();
        Vector2 projectileSize = gameObject
          .GetComponent<SpriteRenderer>()
          .size;
        int magnitude = parentPos.x < 0 ? -1 : 1;
        float projectileX =
          (parentPos.x + magnitude * parentSize.x / 2)
          - (magnitude * projectileSize.x / 2);
        float projectileY = parentPos.y + parentSize.y;

        firedProjectile.transform.position =
        new Vector2(
          projectileX,
          projectileY);
        firedProjectile.GetComponent<Rigidbody2D>().velocity =
          new Vector2(
            0,
            speed);
    }
}
