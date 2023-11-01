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
        this.imageComponent.sprite = FindObjectOfType<Player>().rightHand.equippedItem.gameObject
            .GetComponent<ItemPickUp>().Sprite;
    }
}
