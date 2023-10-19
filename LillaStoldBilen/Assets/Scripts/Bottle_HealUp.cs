using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bottle_HealUp : MonoBehaviour
{
    public int bottleHP = 20;
    public Player HealthPlus;
    public void HealUp ()
    {
        HealthPlus.Health += bottleHP;
    }
}
