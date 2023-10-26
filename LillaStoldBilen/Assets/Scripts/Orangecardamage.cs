using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Orangecardamage : MonoBehaviour
{
    public float maxHealthForOrangeCar = 50f;
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision other)
    {
        Debug.Log($"I collided with {other.gameObject} with an impulse of {other.impulse.magnitude}");

        if (other.impulse.magnitude >= 1)
        {
            
        }
                
    }
}
