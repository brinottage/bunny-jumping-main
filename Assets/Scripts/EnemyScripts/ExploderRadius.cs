using UnityEngine;

public class ExploderRadius : MonoBehaviour
{

    [SerializeField] private EnemyExploder EnemyExploder;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collider)
	{

        Debug.Log("Player in Radius");

       
        // After colliding with the player, or certain other objects, it sets the bomb to explode
		Player player = collider.gameObject.GetComponent<Player>();
        if(EnemyExploder.explode == false) {
            EnemyExploder.explode = true;
            Debug.Log("Enemy Explode Set to True");
        }
        
		
	}

}
