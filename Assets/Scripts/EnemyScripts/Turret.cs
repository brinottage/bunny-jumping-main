using UnityEngine;

public class Turret : MonoBehaviour
{
    public Transform player;
    public float rotationSpeed = 5f;
    public float projectileSpeed = 10f;
    public float fireRate = 1f; // Time in seconds between shots

    [SerializeField] private GameObject projectilePrefab;
    private float fireCooldown;

    void Start()
    {
        GameObject playerObj = GameObject.FindGameObjectWithTag("Player");
        if (playerObj != null)
        {
            player = playerObj.transform;
        }
    }

    void Update()
    {
        if (player != null)
        {
            // Get direction to player
            Vector2 direction = player.position - transform.position;
            float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;

            // Smoothly rotate towards player
            Quaternion targetRotation = Quaternion.Euler(0, 0, angle);
            transform.rotation = Quaternion.Lerp(transform.rotation, targetRotation, rotationSpeed * Time.deltaTime);

            // Handle shooting
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
        if (projectilePrefab != null)
        {
            GameObject projectile = Instantiate(projectilePrefab, transform.position, Quaternion.identity);
            Rigidbody2D rb = projectile.GetComponent<Rigidbody2D>();
            if (rb != null)
            {
                rb.linearVelocity = direction * projectileSpeed;
            }
        }
    }
}