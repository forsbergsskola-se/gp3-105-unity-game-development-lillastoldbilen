using System;
using UnityEngine;

public class Player : MonoBehaviour
{
    public int Health = 90;
    public float MovementSpeed;
    public GameObject onHand;

    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            this.Activate();
            Debug.Log("E is pressed");
        }
    }

    public void Activate()
    {
        
    }
} 