using TMPro;
using UnityEditor.SearchService;
using UnityEngine;

public class HoppingScore : MonoBehaviour
{

    [SerializeField] private TextMeshProUGUI ScoreText;

    private float score;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        score = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void addScore() {

        score += 1;
        ScoreText.text = "Score: " + score;

    }
}
