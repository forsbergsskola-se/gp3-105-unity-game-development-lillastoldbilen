using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bottle_Behavior : MonoBehaviour
{
    public int bottleHP = 20;
    public void UseItem(Player HealthPlus)
    {
        HealthPlus.Health += bottleHP;
        Debug.Log("Player heals up");
    }
}