using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour
{
    public GameObject Bullet;
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
            GameObject newBullet = Instantiate(Bullet, this.transform.position + new Vector3(0,0,1),this.transform.rotation);
            Rigidbody BulletRB = newBullet.GetComponent<Rigidbody>();
            BulletRB.velocity = this.transform.forward * BulletSpeed;
        }

        isShooting = false;
    }
}
