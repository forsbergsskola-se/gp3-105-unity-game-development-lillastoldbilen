using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletBehavior : MonoBehaviour
{
    public float OnscreenDelay = 03f;
    private void OnCollisionEnter(Collision other)
    {
        
        Destroy(this.gameObject, OnscreenDelay);
    }
}
