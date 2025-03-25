using TMPro;
using UnityEngine;

public class Obstacle : MonoBehaviour
{

    private Rigidbody2D rb;
    public float speed = 5f; // Speed of movement

    void Start()
    {

        Destroy(gameObject, 10f);
        
    }

    // Update is called once per frame
    void Update()
    {
        
        transform.position += Vector3.left * speed * Time.deltaTime;

    }
}
