using System;
using TMPro;
using UnityEngine;

public class Victory : MonoBehaviour
{

    [SerializeField] TextMeshProUGUI victoryText;

    // Update is called once per frame
    public void VictoryDisplay(string winner)
    {

        if (winner == "PlayerOne") {
            Debug.Log(victoryText.text);
            victoryText.text = "Player One Wins!";
            Debug.Log(victoryText.text);
        }  else if (winner == "PlayerTwo") {
             Debug.Log(victoryText.text);
            victoryText.text = "Player Two Wins!";
            Debug.Log(victoryText.text);
        }

    }
}
