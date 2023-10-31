using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimation : MonoBehaviour
{
    public Animator animator;
    
    public void Load()
    {
        StartCoroutine(Co_Load());
    }

    IEnumerator Co_Load()
    {
        if (FindObjectOfType<PlayerController>().walkingNow)
        {
            this.animator.SetBool("WhenWalking", true);
        }
        else if (!FindObjectOfType<PlayerController>().walkingNow)
            this.animator.SetBool("WhenWalking", false);
        yield return new WaitForSeconds(0);
    }
}

