using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;

public class Gun : MonoBehaviour
{
    public int magazin = 10;
    public GameObject Bullet;
    public float BulletSpeed = 700f;

    private bool isShooting;
    
    void Update()
    { 
        isShooting |= Input.GetKeyDown(KeyCode.Mouse0);
    }

    void FixedUpdate()
    {
        if (isShooting && magazin > 0)
        {
            GameObject newBullet = Instantiate(Bullet, this.transform.position + new Vector3(0,0,1),this.transform.rotation);
            Rigidbody BulletRB = newBullet.GetComponent<Rigidbody>();
            BulletRB.velocity = this.transform.forward * BulletSpeed;
            magazin--;
        }
        if (magazin == 0)
            Debug.Log("Magazin is empty");
        

        isShooting = false;
    }
}
