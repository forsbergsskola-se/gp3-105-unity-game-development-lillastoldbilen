using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class Fire_Damage : MonoBehaviour
{
    public void OnCollisionStay(Collision other)
    {
        if (other.gameObject.name == "Player")
        {
            PlayerHealth player = other.gameObject.GetComponent<PlayerHealth>();
            float takenDamage = 2 * Time.deltaTime;
            player.TakeDamage(takenDamage);
        }
    }
}