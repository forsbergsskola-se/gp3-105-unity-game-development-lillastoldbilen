using System;
using UnityEngine;

public class Player : MonoBehaviour
{
    public int Health = 90;
    public float MovementSpeed;
    public GameObject onHand;
    public Gun gun;
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
            Action();
    }

    public void Action()
    {
        
    }
} 