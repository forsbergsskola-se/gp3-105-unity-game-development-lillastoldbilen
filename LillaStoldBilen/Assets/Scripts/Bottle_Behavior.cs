using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bottle_Behavior : MonoBehaviour
{
    public InteractableObject PickUp; //Unfinished
    public int bottleHP = 20;
    public void UseItem(Player Health)
    {
        Health.Health += bottleHP;
        Debug.Log("Player heals up");
        Destroy(this);
    }
}