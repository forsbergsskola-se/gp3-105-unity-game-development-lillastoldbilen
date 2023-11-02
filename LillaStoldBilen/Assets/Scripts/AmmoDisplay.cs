using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class AmmoDisplay : MonoBehaviour
{
    public bool isFiring;
    public Text ammoDisplay;
    public TMP_Text reloadText;
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

        if (gun.magazin < 1 && !gun.isReloading)
        {
            reloadText.text = "[R] to reload!";
            reloadText.gameObject.SetActive(true);
        }
        else if (gun.magazin == 10)
        {
            reloadText.gameObject.SetActive(false);
        }
        else if (gun.isReloading)
        {
            reloadText.text = "Reloading...";
            reloadText.gameObject.SetActive(true);
        }
        else
        {
            reloadText.gameObject.SetActive(false);
        }
    }
}
