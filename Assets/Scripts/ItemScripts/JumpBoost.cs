using UnityEngine;

public class JumpBoost : Item
{
    

    public override void effect(Player player) {

        Debug.Log("Contact");
        player.rb.AddForce(Vector2.up * 50f, ForceMode2D.Impulse);
        

    }
}
