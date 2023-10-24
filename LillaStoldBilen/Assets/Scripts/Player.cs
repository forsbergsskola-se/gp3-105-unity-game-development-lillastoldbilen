using System;
using System.Linq;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Events;

public class Player : MonoBehaviour

{
    public int Health = 90;
    public float MovementSpeed;
    public int MoneyBag;
    public Item onHand;
    
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            // UseItem(onHand); TODO: Fix code by angelo
        }
            
        
        
        
        
        //For item-pick ups
        RaycastHit hit; 
        if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out hit, 2.0f) == FindObjectOfType<Item>())
        
        {
                Item itemToPickUp = hit.collider.GetComponent<Item>();
                Debug.Log($"Picked up {FindObjectOfType<Item>()}");
            
        }
    }

    public void UseItem()
    {
        
    }
}