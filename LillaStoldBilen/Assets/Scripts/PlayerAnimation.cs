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
        
        this.animator.SetBool("GunInHand",GetComponent<Player>().rightHand.equippedItem == GetComponent<Gun>().gameObject);
        this.animator.SetBool("GunTrigger",GetComponent<Gun>().isShooting);
    }
    
}