using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleDamage : MonoBehaviour
{

	[SerializeField] private bool IgnoreInvinciblity = false;

	private void OnCollisionEnter2D(Collision2D collision)
	{
		HoppingPlayer player = collision.gameObject.GetComponent<HoppingPlayer>();
		player.GameOver();
			
			
		
	}

	private void OnTriggerEnter2D(Collider2D collider)
	{

		// Destroys player on collision
		Player player = collider.gameObject.GetComponent<Player>();
		player.GameOver();
		
	}
}
