using System;
using UnityEngine;
using UnityEngine.Events;

public class Cops : MonoBehaviour
{
    public float Health = 150;
    public float MovementSpeed;
    public UnityEvent OnDeath;

    void Update()
    {
        if (Health <= 0)
        {
            Destroy(this.gameObject);
            Debug.Log("Cop killed!");
        }
    }
    private void OnDestroy()
    { 
        this.OnDeath.Invoke();
    }
}