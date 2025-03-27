using System;
using TMPro;
using UnityEngine;

public class Victory : MonoBehaviour
{

    [SerializeField] TextMeshProUGUI victoryText;

    
    public void VictoryDisplay(string winner)
    {

        // Announces Player One as the winner by changing the victoryText
        if (winner == "PlayerOne") {
            
            victoryText.text = "Player One Wins!";
            
        }  
        // Announces Player Two as the winner by changing the victoryText
        else if (winner == "PlayerTwo") {
           
            victoryText.text = "Player Two Wins!";
           
        }

    }
}
