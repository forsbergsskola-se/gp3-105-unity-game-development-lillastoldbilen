using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletBehavior : MonoBehaviour
{
    public float OnscreenDelay = 1f;
    private void OnCollisionEnter(Collision other)
    {
        
        Destroy(this.gameObject, OnscreenDelay);
    }
}
