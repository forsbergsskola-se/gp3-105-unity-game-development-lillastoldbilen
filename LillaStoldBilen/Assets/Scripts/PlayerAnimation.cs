using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimation : MonoBehaviour
{
    public Animator animator;

    void Update()
    {
        this.animator.SetBool("WhenWalking", this.GetComponent<PlayerController>().walkingNow);
        this.animator.SetBool("Dying", FindObjectOfType<GameOverUI>().deathAnimation);
        if (FindObjectOfType<Player>().rightHand.equippedItem == (gameObject.name == "Gun)"))
        {
            this.animator.SetBool("GunTrigger", this.GetComponent<Gun>().isShooting);
        }
    }
}