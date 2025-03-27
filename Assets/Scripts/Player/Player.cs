using System;
using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
	[SerializeField] private GameObject DeadEffect; // Death animation
	[HideInInspector] bool isGameOver = false;

	public Rigidbody2D rb;

	public bool isInvincible; // Whether or not the player is invincible

	 private float invinciblityTimer; // How long invincibility lasts

	public bool racing;

    void Start()
    {
        Rigidbody2D rb = GetComponent<Rigidbody2D>();

		isInvincible = false; // Player begins vulnerable to all forms of damage

		Debug.Log(isInvincible);
    }


	void Update()
    {
		// Disables invincibility after 5 seconds
        if (isInvincible)
        {
            invinciblityTimer += Time.deltaTime;
            if (invinciblityTimer >= 5f)
            {
                isInvincible = false;
                invinciblityTimer = 0f;
                
            }
        }
    }


    public virtual void GameOver()
	{
		if (!isGameOver)
		{
			isGameOver = true;


			GetComponent<Animator>().SetTrigger("hurt");

			GetComponent<Movement>().enabled = false;
			GetComponent<PlayerRotater>().enabled = false;

			TwistRigidbody();
			InstantiateParicles();

			FindFirstObjectByType<Camera>().GetComponent<FollowObject>().enabled = false;
			FindFirstObjectByType<PlatformCleaner>().GetComponent<FollowObject>().enabled = false;
			if (!racing) {
				FindFirstObjectByType<ScoreCounter>().enabled = false;
			} // If Climbing Mode is active and the game has ended, the Score counter is disabled

			Destroy(gameObject, 3f);
		}
	}

	public void OnDestroy()
	{
		Debug.Log("Destroyed");
		Scene scene = SceneManager.GetActiveScene();
		SceneManager.LoadScene(scene.name);
	}

	private void TwistRigidbody()
	{
		Rigidbody2D rigidbody = GetComponent<Rigidbody2D>();
		BoxCollider2D boxCollider = GetComponent<BoxCollider2D>();
		boxCollider.enabled = false;
		rigidbody.bodyType = RigidbodyType2D.Dynamic;
		rigidbody.linearVelocity = Vector2.up * 7f;
		rigidbody.freezeRotation = false;
		rigidbody.AddTorque(245f * (UnityEngine.Random.value > 0.5f ? 1f : -1f), ForceMode2D.Force);
	}

	private void InstantiateParicles()
	{
		GameObject paricles = Instantiate(DeadEffect, transform.position, new Quaternion());
		paricles.transform.localScale.Set(3, 3, 1);
		paricles.GetComponent<ParticleSystem>().startColor = new Color(0.51f, 0.47f, 0.46f);
	}

	
}
