using UnityEngine;

public class Invulnerable : Item
{
    public override void effect(Player player) {

        player.isInvincible = true;
        

    }
}
