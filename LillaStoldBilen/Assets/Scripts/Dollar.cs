using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;using UnityEngine.Events;

public class Dollar : MonoBehaviour
{
    public int dollar = 50; //Value of dollar
    private int RotationSpeed = 100;
    private Transform dollarTransform;

    //Rotation-animation
    void Start()
    {
        dollarTransform = this.GetComponent<Transform>();
    }

    void Update()
    {
        dollarTransform.Rotate(0,RotationSpeed* Time.deltaTime,0);
    }
    
    
    
    public void OnCollisionEnter(Collision other) //When player collects
    {
        if (other.gameObject.name == "Player")
        {
            Player player = other.gameObject.GetComponent<Player>();
            player.CashIn(dollar);
            Destroy(this.transform.gameObject);
        }
    }
}
