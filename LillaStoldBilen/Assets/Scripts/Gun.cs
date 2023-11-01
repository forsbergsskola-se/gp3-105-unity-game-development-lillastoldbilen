using System;
using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.Serialization;

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
    
    void Update()
    {
        if (this.gameObject == FindObjectOfType<Player>().rightHand.equippedItem)
        {
            UseThisItem |= Input.GetKeyDown(KeyCode.Mouse0);

            if (Input.GetKeyDown(KeyCode.R))
            {
                Invoke("Reload", 2); // Reload Cooldown
                reloadText.text = "Reloading...";
                reloadText.gameObject.SetActive(true);
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
    }
    
    public void OnPickup()
    {
        onPickedUp.Invoke();
    }
}