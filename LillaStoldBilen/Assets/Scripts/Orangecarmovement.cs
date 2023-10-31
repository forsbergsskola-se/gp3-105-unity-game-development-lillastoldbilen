using System;
using JetBrains.Annotations;
using Unity.VisualScripting;
using UnityEditor.Build.Content;
using UnityEngine;

public class Orangecarmovement : MonoBehaviour
{
    public float accelerationSpeed = 10f;
    public float turnSpeed = 5f;
    public float reverseSpeed = 10f;
    public bool InCar = false;
    public FollowPlayer followPlayer;
    public PlayerController playerController;
    private GameObject oldFollowTarget;
    public GameObject exitCarSpawn;
    
    void Update()
    {
        if (Input.GetKey(KeyCode.E) && InCar)
        {
            ExitCar(); 
        }
        
        if (InCar)
        {
            if (Input.GetKey(KeyCode.W))
            {
                GetComponent<Rigidbody>().AddForce(transform.forward * accelerationSpeed, ForceMode.Acceleration);
            }
            if (Input.GetKey(KeyCode.S))
            {
                GetComponent<Rigidbody>().AddForce(transform.forward * -accelerationSpeed, ForceMode.Acceleration);
            }
            if (Input.GetKey(KeyCode.A))
            {
                transform.Rotate(Vector3.up, -turnSpeed * Time.deltaTime);
            }
            if (Input.GetKey(KeyCode.D))
            {
                transform.Rotate(Vector3.up, turnSpeed * Time.deltaTime);
            }
        }
       
    }

    public void ExitCar()
    {
        PlayerController playerController = this.playerController;
        this.playerController = null;
       playerController.gameObject.SetActive(true); 
       InCar = false;
       followPlayer.player = this.oldFollowTarget;
       this.oldFollowTarget = null;
       playerController.gameObject.transform.position = exitCarSpawn.transform.position;
    }
    
    public void EnterCar(PlayerController playerController)
    {
        Orangecardamage car = this.gameObject.GetComponent<Orangecardamage>();
        if (car.isCarDestroyed)
        {
            return;
        }
        
        playerController.gameObject.SetActive(false);
        InCar = true;
        this.oldFollowTarget = followPlayer.player;
        followPlayer.player = this.gameObject; //Camera follows now car
        
        // save playerController to a field
        this.playerController = playerController;
    }
    
}
