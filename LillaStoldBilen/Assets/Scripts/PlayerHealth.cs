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
    public Player player;

    public void TakeDamage(float damage)
    {
        health -= damage;
        Debug.Log("Health = " + health.ToString());
        OnPlayerHealthChanged.Invoke(health);
    }
    
}