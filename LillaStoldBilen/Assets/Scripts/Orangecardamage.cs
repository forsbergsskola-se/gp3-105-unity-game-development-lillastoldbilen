using System;
using System.Diagnostics.Contracts;
using DefaultNamespace;
using Palmmedia.ReportGenerator.Core.Reporting.Builders;
using UnityEngine;

public class Orangecardamage : MonoBehaviour
{
    
    public float maxHealthForOrangeCar = 100f;
    public float damageAmount = 10f;
    private float orangeCarCurrentHealth;
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
            PlayerHealth player = car.playerController.gameObject.GetComponent<PlayerHealth>();
            float takenDamage = 5f;
            player.TakeDamage(takenDamage);
            car.ExitCar();
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


