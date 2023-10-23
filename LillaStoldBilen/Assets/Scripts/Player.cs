using System;
using System.Linq;
using UnityEngine;
using UnityEngine.Events;

public class Player : MonoBehaviour

{
    public UnityEvent Items;
    public int Health = 90;
    public float MovementSpeed;
    public GameObject onHand;
    public int MoneyBag;
    
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
            Action();
    }
    public void Action()
    {
        
    }
} 