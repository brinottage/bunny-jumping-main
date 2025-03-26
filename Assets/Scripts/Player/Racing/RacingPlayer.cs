using TMPro;
using UnityEngine;

public class RacingPlayer : Player
{
    [SerializeField] public bool isPlayerOne;

    [SerializeField] Victory VictoryText;

    public override void GameOver()
	{
        if (isPlayerOne) {
            Debug.Log("P2 wins");
            VictoryText.VictoryDisplay("PlayerTwo");
        } else {
            Debug.Log("P1 wins");
            VictoryText.VictoryDisplay("PlayerOne");
        }

         base.GameOver();
		
	}

}
