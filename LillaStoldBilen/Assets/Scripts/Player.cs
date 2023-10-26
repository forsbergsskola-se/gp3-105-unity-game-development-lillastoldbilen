using System;
using System.Linq;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.Serialization;

public class Player : MonoBehaviour

{
    public Transform handTransform;
    
    public int Health = 90;
    public float MovementSpeed;
    public int MoneyBag;
    public GameObject[] hands = new GameObject[2];
    
    public void CashIn(int money)
    {
        MoneyBag += money;
    }

    public Transform GetHandTransform()
    {
        return handTransform;
    }
    
    public void PickUpItem(GameObject item)
    {
        
    }
}