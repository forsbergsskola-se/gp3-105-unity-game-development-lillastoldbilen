using System;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.Serialization;

public class Gun : MonoBehaviour
{   
    public UnityEvent onPickedUp;
    
    public int magazin = 10;
    public GameObject Bullet;

    private Transform barrel;
    
    public float BulletSpeed = 100f;
    public bool UseThisItem;

    private void Start()
    {
        barrel = transform.GetComponent<Gun>().transform;
    }

    void Update()
    {
        if (this.gameObject == FindObjectOfType<Player>().rightHand.equippedItem)
        {
            UseThisItem |= Input.GetKeyDown(KeyCode.Mouse0);

            if (Input.GetKeyDown(KeyCode.R))
            {
                Invoke("Reload", 2); // Reload Cooldown
            }

            if (UseThisItem && magazin > 0)
            {
                GameObject newBullet = Instantiate(Bullet, barrel.position, Quaternion.LookRotation(FindObjectOfType<Camera>().transform.forward));
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