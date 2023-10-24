using System;
using System.Linq;
using UnityEngine;
using UnityEngine.Events;

public class Player : MonoBehaviour

{
    public int Health = 90;
    public float MovementSpeed;
    public GameObject onHand;
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
            inventory[0] = itemToPickUp;
            Debug.Log($"Picked up {itemToPickUp}");
        }
    }
}