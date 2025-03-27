using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
	public float moveSpeed = 1.5f; // Determines speed of movement

	private Rigidbody2D rb;

	[SerializeField] private RacingPlayer rp; // Stores the RacingPlayer it is attached to

	private void Awake()
	{
		rb = GetComponent<Rigidbody2D>();
	}

	private void FixedUpdate()
    {
        float move = 0f;

		if (rp != null){ // Activates if the Racing mode is set

		
        	if (rp.isPlayerOne) 
        	{
            	
				// Player One uses the left and right arrows
            	move = Input.GetAxis("Horizontal");
        	}
        	else
        	{
				// Player Two uses key A and key D
            	move = Input.GetAxis("Vertical");
        	}

        

		} else {

			// If there is no RacingPlayer, then the game mode is Climbing
			// The Player uses the left and right arrows
			move = Input.GetAxis("Horizontal");
		}

		// Movement is applied 
		// Sped up via moveSpeed
		rb.linearVelocity = new Vector2(moveSpeed * move, rb.linearVelocity.y);

		
    }
}
