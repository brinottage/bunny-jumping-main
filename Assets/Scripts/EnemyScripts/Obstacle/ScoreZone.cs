using TMPro;
using UnityEngine;

public class ScoreZone : MonoBehaviour
{

    private HoppingScore Score;

    private bool scored;

    private bool canScore = true;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Score = FindAnyObjectByType<HoppingScore>();

    }

    // Update is called once per frame
    void Update()
    {
        // Upon colliding with the score zone, th score counter is increased
        if (scored && canScore) {
            Score.addScore();
            scored = false;
            canScore = false;
        }
    }

    private void OnTriggerEnter2D(Collider2D collider)
	{
    
        Debug.Log("Score");
        if (scored == false) {
            scored = true;
        }
        
		
	}
}
