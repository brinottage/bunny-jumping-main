using UnityEngine;

public class ObstacleSpawner : MonoBehaviour
{

    [SerializeField] private Obstacle obstaclePrefab;
    [SerializeField] private float spawnRate = 3f; 

    private float maxSpawnRate = 6f;
    [SerializeField] private float minY = 0f;
    
    [SerializeField] private float maxY = 5f;
    [SerializeField] private float spawnX = 10f;

    private float seconds = 0f;

    void Start()
    {
        InvokeRepeating(nameof(SpawnObstacle), 0f,spawnRate);
    }

    void Update()
    {
        IncreaseSpawnRate();
    }

    void SpawnObstacle()
    {
        // Spawn obstacle within a range
        float randomY = Random.Range(minY, maxY);
        Vector2 spawnPosition = new Vector2(spawnX, randomY);
        
        Instantiate(obstaclePrefab, spawnPosition, Quaternion.identity);
    }

    private void IncreaseSpawnRate() {

        // Increase spawn rate by 1 every 60 seconds
        seconds += Time.deltaTime;
        if (seconds >= 60f && spawnRate > 1f)
        {
            spawnRate = Mathf.Min(spawnRate + 1f, maxSpawnRate);
            seconds = 0f;
            CancelInvoke(nameof(SpawnObstacle));
            InvokeRepeating(nameof(SpawnObstacle), 0f, spawnRate);
        }
    }
}
