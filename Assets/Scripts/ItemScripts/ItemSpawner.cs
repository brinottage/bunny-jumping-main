using System.Collections;
using UnityEditor;
using UnityEngine;

public class ItemSpawner : MonoBehaviour
{


    [SerializeField] private JumpBoost JumpBoostItemPrefab;

    [SerializeField] private Invulnerable InvulnItemPrefab;

    [SerializeField] private FalseItem FalseItemPrefab;

    private Vector3 spawnPos; // Where the item sapwns

    private float totalTime = 15f; // Time between potential spawns

    private float currentTime;

    void Start()
    {
      currentTime = totalTime;
    }

    void Update()
    {
        currentTime -= Time.deltaTime; 
        if (currentTime <= 0)
        {
            SpawnJumpBoost();
            SpawnInvulnerable();
            SpawnFalseItem();
            currentTime = totalTime;
            
        }
    }
    

    private void SpawnJumpBoost(){

        // Gets spawnPos in a certain range of X and the Y pos of the ItemSpawner
        spawnPos = new Vector3(Random.Range(-10, 10), gameObject.transform.position.y, gameObject.transform.position.z);

        // Every 10 seconds, roll a random num. If it's below the Item's Chance, the Item spawns
        float randomNum = UnityEngine.Random.Range(0f, 100f);

        // Spawns Item at Prefab
        if (randomNum <= JumpBoostItemPrefab.chance) {
            Instantiate(JumpBoostItemPrefab, spawnPos, transform.rotation);
        }
    }

    private void SpawnInvulnerable(){

        // Gets spawnPos in a certain range of X and the Y pos of the ItemSpawner
        spawnPos = new Vector3(Random.Range(-10, 10), gameObject.transform.position.y, gameObject.transform.position.z);

        // Every 10 seconds, roll a random num. If it's below the Item's Chance, the Item spawns
        float randomNum = UnityEngine.Random.Range(0f, 100f);

        // Spawns Item at Prefab
        if (randomNum <= InvulnItemPrefab.chance) {
            Instantiate(InvulnItemPrefab, spawnPos, transform.rotation);
        }
    }

    private void SpawnFalseItem(){

        // Gets spawnPos in a certain range of X and the Y pos of the ItemSpawner
        spawnPos = new Vector3(Random.Range(-10, 10), gameObject.transform.position.y, gameObject.transform.position.z);

        // Every 10 seconds, roll a random num. If it's below the Item's Chance, the Item spawns
        float randomNum = UnityEngine.Random.Range(0f, 100f);

        // Spawns Item Item at Prefab
        if (randomNum <= FalseItemPrefab.chance) {
            Instantiate(FalseItemPrefab, spawnPos, transform.rotation);
        }
    }


}
