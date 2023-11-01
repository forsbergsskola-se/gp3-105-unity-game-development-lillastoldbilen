using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;

public class PlayerHealth : MonoBehaviour
{
    public UnityEvent<float> OnPlayerHealthChanged;
    public float health = 100f;
    
    public bool deathAnimation; // Animation-Purpose

    public void TakeDamage(float damage)
    {
        health -= damage;
        Debug.Log("Health = " + health.ToString());
        OnPlayerHealthChanged.Invoke(health);
        if(health <= 0)
            deathAnimation = true;
        deathAnimation = false;
    }
    
}