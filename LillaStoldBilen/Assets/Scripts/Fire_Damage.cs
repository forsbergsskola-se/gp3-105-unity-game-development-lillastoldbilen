using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class Fire_Damage : MonoBehaviour
{
    private void Update() // Fire lifespan
    {
        Invoke("Extinguish", 20);
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.name == "Player")
        {
            PlayerHealth player = other.gameObject.GetComponent<PlayerHealth>();
            float takenDamage = 10 * Time.deltaTime;
            player.TakeDamage(takenDamage);
        }
        else if (other.gameObject.name == "Orange car")
        {
            Orangecardamage car = other.gameObject.GetComponent<Orangecardamage>();
            float takenDamage = 5 * Time.deltaTime;
            car.maxHealthForOrangeCar -= takenDamage;
            Debug.Log($"Cars Health {car.maxHealthForOrangeCar} damage");
        }
    }

    void Extinguish()
    {
        Destroy(this.gameObject);
    }
}