using System;
using UnityEngine;
using UnityEngine.Events;

public class Cops : MonoBehaviour
{
    public float Health = 150;
    public UnityEvent OnDeath;

    void Update()
    {
        if (Health <= 0)
        {
            Invoke("CopDies",3);
            Debug.Log("Cop killed!");
        }
    }
    private void OnDestroy()
    { 
        this.OnDeath.Invoke();
    }

    void CopDies()
    {
        Destroy(this.gameObject);
    }
}