wusing System;
using System.Linq;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Events;

public class Player : MonoBehaviour

{
    public int Health = 90;
    public float MovementSpeed;
    public int MoneyBag;
    public bool onHand;
    public GameObject[] InHands = new GameObject[2];
}