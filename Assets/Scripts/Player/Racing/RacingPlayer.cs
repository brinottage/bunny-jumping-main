using TMPro;
using UnityEngine;

public class RacingPlayer : Player
{
    [SerializeField] public bool isPlayerOne; // Stores whether the current player is player one or not

    [SerializeField] Victory VictoryText; // Reference to the Victory Text ui

    public override void GameOver()
	{
        // Sends which player won to the victory text UI
        if (isPlayerOne) {
            Debug.Log("P2 wins");
            VictoryText.VictoryDisplay("PlayerTwo");
        } else {
            Debug.Log("P1 wins");
            VictoryText.VictoryDisplay("PlayerOne");
        }

        // Runs the base GameOver code
         base.GameOver();
		
	}

}
