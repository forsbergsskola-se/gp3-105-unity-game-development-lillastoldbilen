using System;
using System.Linq;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Events;

public class Player : MonoBehaviour

{
    public int Health = 90;
    public float MovementSpeed;
    public int MoneyBag;
    public GameObject[] hands = new GameObject[2];

    public void CashIn(int money)
    {
        MoneyBag += money;
    }

    public void PickUpItem(GameObject item)
    {
        for (int i = 0; i < hands.Length; i++)
        {
            if (hands[i] != null)
            {
                hands[i] = item;
                Debug.Log($"Collected {item}");
                return;
            }
            else
                Debug.Log("Your hands are full!");
        }
    }
}