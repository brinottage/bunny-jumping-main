using UnityEngine;

public class Turret : MonoBehaviour
{
    public Transform player;
    public float rotationSpeed = 5f; 

    [SerializeField] private GameObject projectilePrefab;

    [SerializeField] private Transform firePoint; 
    [SerializeField] private float fireRate = 1f; 
    [SerializeField] private float projectileSpeed = 10f;


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

        }
    }

}
