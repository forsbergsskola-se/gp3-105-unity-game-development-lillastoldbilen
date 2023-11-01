using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class Equipped : MonoBehaviour
{
    public Image imageComponent;
    public Sprite sprite;
    void Update()
    {
        FindObjectOfType<Player>().rightHand.equippedItem.gameObject.GetComponent<ItemPickUp>().Sprite;
        this.imageComponent.sprite = sprite;
    }
}
