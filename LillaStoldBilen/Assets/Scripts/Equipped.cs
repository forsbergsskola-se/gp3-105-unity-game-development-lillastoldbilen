using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class Equipped : MonoBehaviour
{
    public Image imageComponent;
    void Update()
    {
        if (FindObjectOfType<Player>().rightHand.equippedItem == null)
        {
            imageComponent.enabled = false;
        }
        else
        {
            imageComponent.enabled = true;
            this.imageComponent.sprite = FindObjectOfType<Player>().rightHand.equippedItem.gameObject
                .GetComponent<ItemPickUp>().Sprite;
        }
    }
}
