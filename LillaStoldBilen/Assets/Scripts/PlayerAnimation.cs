using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimation : MonoBehaviour
{
    public Animator animator;

    void Update()
    {
        this.animator.SetBool("WhenWalking",this.GetComponent<PlayerController>().walkingNow);
    }
}