using Unity.Mathematics;
using UnityEngine;

public class ItemPickUp : MonoBehaviour
{

    void OnCollisionEnter(Collision other)
    {
        Player player = other.gameObject.GetComponent<Player>();
        if (player == null) return;
            
        Hand hand = player.GetHand();
        if (hand != null && hand.HasEquippedItem() == false)
        {
            hand.Equip(this.gameObject);
        }
    }
}