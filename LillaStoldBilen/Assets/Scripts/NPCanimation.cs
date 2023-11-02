using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCanimation : MonoBehaviour
{
    public Animator NPCanimator;

    
    public void OnCollisionEnter(Collision other)
    {
        this.transform.Rotate(0, 90, 0);
    }
}
