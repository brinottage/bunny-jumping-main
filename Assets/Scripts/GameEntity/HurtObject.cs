using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HurtObject : MonoBehaviour
{

	[SerializeField] private bool IgnoreInvinciblity = false; // Ignores invincibility

	private void OnCollisionEnter2D(Collision2D collision)
	{
		Player player = collision.gameObject.GetComponent<Player>();
		if (player != null)
		{

			
			if (IgnoreInvinciblity) {
				if (collision.contacts[0].normal.y >= -0.3f)
				{
					player.GameOver();
				}
			} else {
				if (collision.contacts[0].normal.y >= -0.3f && player.isInvincible == false)
				{
					player.GameOver();
				}
			}
			
		}
	}

	private void OnTriggerEnter2D(Collider2D collider)
	{
		Player player = collider.gameObject.GetComponent<Player>();

		if (IgnoreInvinciblity){
			if (player != null)
			{
				player.GameOver();
			}

		} else {
			if (player != null && player.isInvincible == false)
			{
				player.GameOver();
			}

		}
		
	}
}
