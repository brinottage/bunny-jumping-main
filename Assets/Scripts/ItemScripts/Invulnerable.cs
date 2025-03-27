using System.Runtime.CompilerServices;
using UnityEngine;

public class Invulnerable : Item
{



    public override void effect(Player player) {

        // The player is made near-invincible for 5 seconds,
        // during which nothing can harm them save for the spikes
        if (player.isInvincible == false){

            Debug.Log("Inv on");
            player.isInvincible = true;

        }

    }
}
