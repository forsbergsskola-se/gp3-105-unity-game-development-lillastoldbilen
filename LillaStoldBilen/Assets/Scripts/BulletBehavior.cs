using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Android;
using UnityEngine.UIElements;

public class BulletBehavior : MonoBehaviour
{
    public float OnscreenDelay = 0001f;
    public float BulletDamage = 50;
    public GameObject BulletFire;
    public void OnCollisionEnter(Collision other)
    { 
        Invoke("BulletBreak",1);
        
        GameObject bulletFire = Instantiate(BulletFire, this.transform);
        
        if (other.gameObject.name == "Cops")
        {
            other.gameObject.GetComponent<Cops>().Health -= BulletDamage;
        }
    }

    private void BulletBreak()
    {
        Destroy(this.gameObject);
    }
}
