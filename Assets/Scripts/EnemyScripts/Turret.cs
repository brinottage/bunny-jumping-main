using UnityEngine;

public class Turret : MonoBehaviour
{
    public Transform player;
    public float rotationSpeed = 5f;
    public float projectileSpeed = 10f;
    private float fireRate = 1f; // 1 second between shots

    [SerializeField] private GameObject projectilePrefab;
    private float fireCooldown;

    void Start()
    {
        GameObject playerObj = GameObject.FindGameObjectWithTag("Player");
        if (playerObj != null)
        {
            player = playerObj.transform;
        }

        // Obstacle destroys itself after 10 seconds
        Destroy(gameObject, 10f);
    }

    void Update()
    {
        if (player != null)
        {
            // Get direction between the player and the turret. Rotates the turret to always face the player
            Vector2 direction = player.position - transform.position;
            float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
           
            Quaternion targetRotation = Quaternion.Euler(0, 0, angle);
            transform.rotation = Quaternion.Lerp(transform.rotation, targetRotation, rotationSpeed * Time.deltaTime);

            // Firing Cooldown
            fireCooldown -= Time.deltaTime;
            if (fireCooldown <= 0f)
            {
                Shoot(direction.normalized);
                fireCooldown = fireRate;
            }
        }
    }

    void Shoot(Vector2 direction)
    {
        // Fires the bullet projectile at the player
        
        GameObject projectile = Instantiate(projectilePrefab, transform.position, Quaternion.identity);
        Rigidbody2D rb = projectile.GetComponent<Rigidbody2D>();
        if (rb != null){
                rb.linearVelocity = direction * projectileSpeed;
        
        }
        
    }
}