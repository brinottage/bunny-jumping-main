using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
	public float moveSpeed = 1.5f;

	private Rigidbody2D rb;

	[SerializeField] private RacingPlayer rp;

	private void Awake()
	{
		rb = GetComponent<Rigidbody2D>();
	}

	/*private void FixedUpdate()
	{
		float move = Input.GetAxis("Horizontal");
		

		if (!rp.isPlayerOne) {
			
		}

		rb.linearVelocity = new Vector2(moveSpeed * move, rb.linearVelocity.y);
	}*/

	private void FixedUpdate()
    {
        float move = 0f;

		if (rp != null){

		
        	if (rp.isPlayerOne) 
        	{
            	
            	move = Input.GetAxis("Vertical");
        	}
        	else
        	{
            	move = Input.GetAxis("Horizontal");
        	}

        

		} else {
			move = Input.GetAxis("Vertical");
		}

		rb.linearVelocity = new Vector2(moveSpeed * move, rb.linearVelocity.y);

		
    }
}
