using System;
using System.Linq;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Events;

public class Player : MonoBehaviour

{
    public int Health = 90;
    public bool isAlive = true;
    public float MovementSpeed;
    public int MoneyBag;
    public bool onHand;
    public GameObject InHand = new GameObject();

    void Update()
    {
        CheckAlive();
    }
    
    private void CheckAlive()
    {
        if (Health > 0)
            isAlive = false;
    }
}