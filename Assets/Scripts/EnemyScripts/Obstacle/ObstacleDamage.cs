using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleDamage : MonoBehaviour
{

	[SerializeField] private bool IgnoreInvinciblity = false;

	private void OnCollisionEnter2D(Collision2D collision)
	{
		HoppingPlayer player = collision.gameObject.GetComponent<HoppingPlayer>();
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
