using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletBehavior : MonoBehaviour
{
    public float OnscreenDelay = 001f;
    public GameObject BulletFire;
    private void OnCollisionEnter(Collision other)
    {
        GameObject bulletFire = Instantiate(BulletFire, this.transform);
        Destroy(this.gameObject, OnscreenDelay);
    }
}
