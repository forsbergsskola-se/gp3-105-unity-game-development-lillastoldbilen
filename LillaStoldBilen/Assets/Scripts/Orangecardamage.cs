using System;
using UnityEngine;

public class Orangecardamage : MonoBehaviour
{
    
    public float maxHealthForOrangeCar = 100f;
    public float damageAmount = 10f;
    public float orangeCarCurrentHealth;
    public bool isCarDestroyed;

    private void Start()
    {
        orangeCarCurrentHealth = maxHealthForOrangeCar;
    }

    private void TakeDamage(float amount)
    {
        this.orangeCarCurrentHealth -= amount;
        if (orangeCarCurrentHealth <= 0)
        {
            isCarDestroyed = true;
            PlayerPunishment();
        }
    } 
    

    void PlayerPunishment()
    {
        Orangecarmovement car = GetComponent<Orangecarmovement>();
        if (car.InCar)
        {
            // remove some health from the player
            // remove the player from the car
            // and make sure that they cannot enter the car again
            Debug.Log("punishplayer");
        }
    } 

    private void OnCollisionEnter(Collision other)
    {

        Debug.Log($"I collided with {other.gameObject} with an impulse of {other.impulse.magnitude}");
        if (other.impulse.magnitude >= 1)
        {
            TakeDamage(damageAmount);
        }
    }
    
}


