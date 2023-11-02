using System;
using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.Serialization;
using UnityEngine.UI;

public class Gun : MonoBehaviour
{   
    public UnityEvent onPickedUp;
    public TMP_Text reloadText;
    public int magazin = 10;
    public GameObject Bullet;
    
    public Transform barrel;
    
    public float BulletSpeed = 100f;
    public bool UseThisItem;
    public bool isShooting; // Animation-Purpose
    public bool isReloading;
    
    void Update()
    {
        if (this.gameObject == FindObjectOfType<Player>().rightHand.equippedItem)
        {
            UseThisItem |= Input.GetKeyDown(KeyCode.Mouse0);

            if (Input.GetKeyDown(KeyCode.R))
            {
                TextReload();
                Invoke("Reload", 2); // Reload Cooldown
            }

            if (UseThisItem && magazin > 0)
            {
                isShooting = UseThisItem;
                
                Transform barrelEnd = barrel;
                
                GameObject newBullet = Instantiate(Bullet, barrelEnd.position, Quaternion.LookRotation(FindObjectOfType<Player>().transform.forward));
                Rigidbody BulletRB = newBullet.GetComponent<Rigidbody>();
                BulletRB.velocity = newBullet.transform.forward * BulletSpeed;
                magazin--;
            }
            UseThisItem = false;
            isShooting = false;
        }
    }

    public void Reload()
    {
        magazin = 10;
        Debug.Log("Gun is reloaded"); 
        isReloading = false;
    }

    public void TextReload()
    {
        isReloading = true;
    }
    
    public void OnPickup()
    {
        onPickedUp.Invoke();
    }
}