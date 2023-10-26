using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using Unity.VisualScripting;
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
            Player player = other.gameObject.GetComponent<Player>();
            Transform handTransform = player.GetHandTransform();
            transform.SetParent(handTransform);
            transform.localPosition = Vector3.zero;
            transform.localRotation = quaternion.identity;
            Destroy(this.gameObject.GetComponent<Rigidbody>());
        }
    }
}