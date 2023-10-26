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
    
    public int Health = 90;
    public float MovementSpeed;
    public int MoneyBag;
    
    public void CashIn(int money)
    {
        MoneyBag += money;
    }

    public Transform OnHand()
    {
        if (rightHand == null) 
            return rightHand;
        else if (rightHand != null)
            return rightHand;
        else
        {
            Debug.Log("Your hands are full!");
            return null;
        }
    }
}