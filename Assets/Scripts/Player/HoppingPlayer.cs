using System;
using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HoppingPlayer : MonoBehaviour
{
	[SerializeField] private GameObject DeadEffect;
	[HideInInspector] bool isGameOver = false;

	public Rigidbody2D rb;

	public bool isInvincible;

    void Start()
    {
        Rigidbody2D rb = GetComponent<Rigidbody2D>();

		isInvincible = false;

		Debug.Log(isInvincible);
    }

    public void GameOver()
	{
		if (!isGameOver)
		{

            Debug.Log("Game Over");
			isGameOver = true;


			GetComponent<Animator>().SetTrigger("hurt");

			GetComponent<HoppingMovement>().enabled = false;
			//GetComponent<PlayerRotater>().enabled = false;

			TwistRigidbody();
			InstantiateParicles();

			//FindFirstObjectByType<Camera>().GetComponent<FollowObject>().enabled = false;
			//FindFirstObjectByType<PlatformCleaner>().GetComponent<FollowObject>().enabled = false;
			//FindFirstObjectByType<ScoreCounter>().enabled = false;

			Destroy(gameObject, 3f);
		}
	}

	private void OnDestroy()
	{
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
