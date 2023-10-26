using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bottle_Behavior : MonoBehaviour
{
    public int bottleHP = 20;
    private int RotationSpeed = 100;
    private Transform bottleTransform;

    //Rotation-animation
    void Start()
    {
        bottleTransform = this.GetComponent<Transform>();
    }

    void Update()
    {
        bottleTransform.Rotate(RotationSpeed * Time.deltaTime, 0, 0);
    }

    public void OnCollisionEnter(Collision other) //When player collects
    {
        if (other.gameObject.name == "Player")
        {
            Player player = other.gameObject.GetComponent<Player>(); //Does not add to array?
            player.PickUpItem(this.gameObject);
            Destroy(this.gameObject);
        }
    }
}