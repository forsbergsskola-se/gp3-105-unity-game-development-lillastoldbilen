using System;
using UnityEngine;

public class Player : MonoBehaviour

{
    public int Health = 90;
    public float MovementSpeed;
    public GameObject onHand;
    public Gun gun;
    public GameObject[] Inventory = new GameObject[5]; //Bag inventory is 5 "Testing 5"
    public int itemSlot = 0;
    
    void Start()
    {
        onHand = Inventory[itemSlot];
    }
    
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))
            ItemToggle();
        if (Input.GetKeyDown(KeyCode.E))
            Action();

    }

    public void ItemToggle() // To toggle items in possession
    {
        if (Inventory[4])
        {
            onHand = Inventory[0];
        }
        else
            onHand = Inventory[itemSlot+ 1];
        Debug.Log(onHand);
    }

    public void Action()
    {
        
    }
} 