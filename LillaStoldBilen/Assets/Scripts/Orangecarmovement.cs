using Unity.VisualScripting;
using UnityEngine;

public class Orangecarmovement : MonoBehaviour
{
    public float accelerationSpeed = 100f;
    public float turnSpeed = 100f;
    public float reverseSpeed = 100f;
    public bool InCar = false;
    public FollowPlayer followPlayer;
    public GameObject orangeCar;

    public void ActivateCar()
    {
        
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E) && InCar)
        {
            ExitCar(); // I will write a methode later in the code (I need to think first)
        }
        
        if (InCar)
        {
            if (Input.GetKey(KeyCode.W))
            {
                transform.Translate(Vector3.forward * accelerationSpeed * Time.deltaTime);
            }
            if (Input.GetKey(KeyCode.S))
            {
                transform.Translate(Vector3.forward * -reverseSpeed * Time.deltaTime);
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
        
        //transform.position = transform.position;
        //transform.rotation = transform.rotation;
        
        // here, undo everything you've done in EnterCar
    }
    
    public void EnterCar(PlayerController playerController)
    {
        playerController.gameObject.SetActive(false);
        InCar = true;
        // reference followPlayer script
        followPlayer.player = orangeCar;
        // thatScript.player = this.gameObject;
    } 
        
}