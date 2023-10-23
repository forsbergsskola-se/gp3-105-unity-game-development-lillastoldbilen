using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bottle_HealUp : MonoBehaviour
{
    public int bottleHP = 20;
    public void HealUp (Player HealthPlus)
    {
        HealthPlus.Health += bottleHP;
        Debug.Log("Player heals up");
    }
}