using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AmmoDisplay : MonoBehaviour
{
    public bool isFiring;
    public Text ammoDisplay;
    public GameObject reloadText;
    public Gun gun;


    // Update is called once per frame
    void Update()
    {
        ammoDisplay.text = gun.magazin.ToString();
        if (Input.GetMouseButtonDown(0) && !isFiring && gun.magazin > 0)
        {
            isFiring = true;
            isFiring = false;
        }

        if (gun.magazin < 1)
        {
            reloadText.SetActive(true);
        }
        else
        {
            reloadText.SetActive(false);
        }
    }
}
