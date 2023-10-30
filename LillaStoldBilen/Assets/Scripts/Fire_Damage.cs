using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class Fire_Damage : MonoBehaviour
{

    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.name == "Player")
        {
            PlayerHealth player = other.gameObject.GetComponent<PlayerHealth>();
            float takenDamage = 5 * Time.deltaTime;
            player.TakeDamage(takenDamage);
        }
    }
}