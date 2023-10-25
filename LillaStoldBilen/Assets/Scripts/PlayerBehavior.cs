using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerBehavior : MonoBehaviour
{
    public GameObject itemInHand;
    public Dollar dollar;
    public Player player;
    void Update() // OnTrigger() ??
    {
        RaycastHit hit; // When player gets close enough of item, player picks it up
        if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out hit, 2.0f))
        {
            if (hit.collider.CompareTag("Item")) //
            {
                if (player.InHand != null)
                {
                    player.InHand = hit.collider.gameObject; Debug.Log($"Picked up {hit.collider.CompareTag("Item")}");
                }
                Debug.Log("Your hands are full!");
            }
        }
    }
}
