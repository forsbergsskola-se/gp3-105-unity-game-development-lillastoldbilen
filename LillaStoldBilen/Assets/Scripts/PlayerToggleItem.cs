using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerToggleItem : MonoBehaviour

{
    public GameObject rightHand;
    public GameObject leftHand;
    public GameObject currentItem; // The item you want to switch between hands
    private GameObject activeHand;

    void Start()
    {
        // Set the right hand as the initial active hand
        activeHand = rightHand;
    }

    void Update()
    {
        // Check for the "Q" key press to switch the item between hands
        if (Input.GetKeyDown(KeyCode.Q))
        {
            // Determine the target hand for the item
            GameObject targetHand = (activeHand == rightHand) ? leftHand : rightHand;

            // Move the item to the target hand
            currentItem.transform.SetParent(targetHand.transform);
            currentItem.transform.localPosition = Vector3.zero;
            currentItem.transform.localRotation = Quaternion.identity;

            // Update the active hand
            activeHand = targetHand;
        }
    }
}
