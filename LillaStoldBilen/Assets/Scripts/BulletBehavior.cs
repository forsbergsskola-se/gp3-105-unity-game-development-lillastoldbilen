using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Android;
using UnityEngine.UIElements;

public class BulletBehavior : MonoBehaviour
{
    public float OnscreenDelay = 0001f;
    public GameObject BulletFire;
    public void OnCollisionEnter(Collision other)
    { 
        Invoke("BulletBreak",1);
        GameObject bulletFire = Instantiate(BulletFire, this.transform);
    }

    private void BulletBreak()
    {
        Destroy(this.gameObject);
    }
}
