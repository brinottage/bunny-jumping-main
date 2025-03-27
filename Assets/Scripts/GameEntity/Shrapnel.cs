using UnityEngine;

public class Shrapnel : MonoBehaviour
{

    public Vector3 movement;

    [SerializeField] Rigidbody2D rb;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Rigidbody2D rb = GetComponent<Rigidbody2D>();
        rb.linearVelocity = movement; // Moves in accordance to the movement variable
        Destroy(gameObject, 20f); // Destroys itself after 5 seconds
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
