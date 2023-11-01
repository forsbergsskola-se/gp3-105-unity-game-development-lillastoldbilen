using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class Equipped : MonoBehaviour
{
    private Player player;
    public RawImage image;
    public GameObject Gun;
    public GameObject Bottle;
    void Update()
    {
        if (player.rightHand.equippedItem == gameObject.GetComponent<Gun>())
        {
            
        }
    }
}
