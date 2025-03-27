using UnityEngine;
using UnityEngine.Video;

public class Item : MonoBehaviour
{

    private Rigidbody2D rb;

    [SerializeField] public int chance; // Spawn chance

    void Start()
    {
        Rigidbody2D rb = GetComponent<Rigidbody2D>();
        rb.gravityScale = 0; // Disable gravity
        rb.linearVelocity = new Vector2(0, -5f); // Set fall speed   
    }


    private void OnTriggerEnter2D(Collider2D collider)
	{
		Player player = collider.gameObject.GetComponent<Player>();
		if (player != null)
		{

            effect(player);
			Destroy(gameObject);
            
		}
	}

    void Update()
    {

        // Destroy Item within 10 seconds of it not being acquired
        Destroy(gameObject, 10f);
    }

    public virtual void effect(Player player){} // Places an effect on the player upon contact


}
