using TMPro;
using UnityEngine;

public class ScoreZone : MonoBehaviour
{

    private HoppingScore Score;

    private bool scored;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Score = FindAnyObjectByType<HoppingScore>();

    }

    // Update is called once per frame
    void Update()
    {
        if (scored) {
            Score.addScore();
            scored = false;
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
