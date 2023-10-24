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
    public bool onHand;
    void Update()
    {
        if (onHand)
        {
            UseItem(onHand); 
            EquipedItem();
        }
        
        
        
        
        //For item-pick ups (Unfinished!)
        /*RaycastHit hit; 
        if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out hit, 2.0f) == FindObjectOfType<Item>())
        
        {
                Item itemToPickUp = hit.collider.GetComponent<Item>();
                Debug.Log($"Picked up {FindObjectOfType<Item>()}");
            
        }
        */
    }

    public void EquipedItem()
    {
    }
}