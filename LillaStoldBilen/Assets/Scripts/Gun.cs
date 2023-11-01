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
    
    void Update()
    {
        if (this.gameObject == FindObjectOfType<Player>().rightHand.equippedItem)
        {
            UseThisItem |= Input.GetKeyDown(KeyCode.Mouse0);

            if (Input.GetKeyDown(KeyCode.R))
            {
                Invoke("Reload", 2); // Reload Cooldown
                reloadText.gameObject.SetActive(true);
                reloadText.text = "Reloading...";
            }

            if (UseThisItem && magazin > 0)
            {
                Transform barrelEnd = barrel.transform.Find("Barrel"); 
                GameObject newBullet = Instantiate(Bullet, barrelEnd.position, Quaternion.LookRotation(FindObjectOfType<Camera>().transform.forward));
                Rigidbody BulletRB = newBullet.GetComponent<Rigidbody>();
                BulletRB.velocity = newBullet.transform.forward * BulletSpeed;
                magazin--;
            }
            UseThisItem = false;
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