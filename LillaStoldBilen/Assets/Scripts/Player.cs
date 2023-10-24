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
    public GameObject [] inventory;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
            Action();
    }

    public void Action()
    {
        RaycastHit hit;
        if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out hit, 2.0f))
        {
            GameObject itemToPickUp = hit.collider.GetComponent<GameObject>();

            for (int i = 0; i < inventory.Length; i++)
            {
                if (inventory[i] = null)
                {
                    inventory[i] = itemToPickUp;
                    break;
                }
                Debug.Log("Bag is Full!");
            }
            Debug.Log($"Picked up {itemToPickUp}");
        }
    }
}