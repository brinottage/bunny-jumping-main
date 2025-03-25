using UnityEngine;

public class ObstacleSpawner : MonoBehaviour
{

    [SerializeField] private Obstacle obstaclePrefab;
    [SerializeField] private float spawnRate = 2f; 
    [SerializeField] private float minY = -3f;
    
    [SerializeField] private float maxY = 3f;
    [SerializeField] private float spawnX = 10f;

    void Start()
    {
        InvokeRepeating(nameof(SpawnObstacle), 0f, spawnRate);
    }

    void SpawnObstacle()
    {
        float randomY = Random.Range(minY, maxY);
        Vector2 spawnPosition = new Vector2(spawnX, randomY);
        
        Instantiate(obstaclePrefab, spawnPosition, Quaternion.identity);
    }
}
