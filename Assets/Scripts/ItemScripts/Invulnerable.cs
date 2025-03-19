using System.Runtime.CompilerServices;
using UnityEngine;

public class Invulnerable : Item
{

    private float totalTime = 10f;

    private float currentTime;

    public override void effect(Player player) {

        Debug.Log("Pre-Effect:" + player.isInvincible);
        if (player.isInvincible == false){

            Debug.Log("Inv on");
            player.isInvincible = true;

            currentTime = totalTime;
            currentTime -= Time.deltaTime;

            if (currentTime == 0f) {
                player.isInvincible = false;
                Debug.Log("Inv off");
            }

        }
        
        

    }
}
