using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Android;
using UnityEngine.UIElements;

public class BulletBehavior : MonoBehaviour
{
    public float OnscreenDelay = 001f;
    public GameObject BulletFire;
    public void OnCollisionEnter(Collision other)
    {
        Destroy(this.gameObject, OnscreenDelay);
        GameObject bulletFire = Instantiate(BulletFire, this.transform);
    }
}
