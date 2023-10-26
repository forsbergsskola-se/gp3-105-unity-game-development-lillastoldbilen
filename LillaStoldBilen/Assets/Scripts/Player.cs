using System;
using System.Linq;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.Serialization;

public class Player : MonoBehaviour

{ 
    public Transform rightHand;
    public Transform leftHand;
    
    public Transform bag;
    
    public int Health = 90;
    public float MovementSpeed;
    public int MoneyBag;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))
            Toggle();
    }
    
    public void CashIn(int money)
    {
        MoneyBag += money;
    }

    public Transform OnHand()
    {
        if (rightHand.childCount == 0) 
            return rightHand;
        if (leftHand.childCount == 0)
            return leftHand;
        
        Debug.Log("Your hands are full!");
        return null;
    }

    public void Toggle()
    {
        bag = rightHand;
        
        rightHand = leftHand;

        leftHand = bag;
    }
}



/*
class Hand
     public GameObject equippedItem;
     
    public void Equip(Gameobject item)
    public void Unequip()
    public bool HasEquippedItem()
*/


/*
void GetHand()
   if(!leftHand.hasequippedItem) return leftHand;
   if(!rightHand.hasequippedItem) return rightHand;
   return null;
*/