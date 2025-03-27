using TMPro;
using UnityEngine;

public class Obstacle : MonoBehaviour
{

    private Rigidbody2D rb;
    public float speed = 5f;

    void Start()
    {

        // Obstacle destroys itself after 10 seconds
        Destroy(gameObject, 10f);
        
    }

    // Update is called once per frame
    void Update()
    {
        
        transform.position += Vector3.left * speed * Time.deltaTime;

    }
}
