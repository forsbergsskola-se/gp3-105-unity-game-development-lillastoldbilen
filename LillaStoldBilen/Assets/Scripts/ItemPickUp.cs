using Unity.Mathematics;
using UnityEngine;

public class ItemPickUp : MonoBehaviour
{
    private void Start()
    { 
        Bottle_Behavior bottleBehavior = GetComponent<Bottle_Behavior>();
    }
    public void OnPickUp()
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
}