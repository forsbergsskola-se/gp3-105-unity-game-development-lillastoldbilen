using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;

public class Bullet : MonoBehaviour
{
    [FormerlySerializedAs("Bullet")] public GameObject bullet;
    public float BulletSpeed = 100f;

    private bool isShooting;
    
    void Update()
    {
            isShooting |= Input.GetKeyDown(KeyCode.Mouse0);
    }

    void FixedUpdate()
    {
        if (isShooting)
        {
            GameObject newBullet = Instantiate(bullet, this.transform.position + new Vector3(0,0,1),this.transform.rotation);
            Rigidbody BulletRB = newBullet.GetComponent<Rigidbody>();
            BulletRB.velocity = this.transform.forward * BulletSpeed;
        }

        isShooting = false;
    }
}
