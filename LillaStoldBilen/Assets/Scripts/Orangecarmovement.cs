using Unity.VisualScripting;
using UnityEngine;

public class Orangecarmovement : MonoBehaviour
{
    public float accelerationSpeed = 1f; // just random numbers for start: i will change it later 
    public float turnSpeed = 0.5f;
    public float reverseSpeed = 1f;
    private bool InCar = false; // It changed automatically to private here

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E) && InCar)
        {
            ExitCar(); // I will write a methode later in the code (I need to think first)
        }
        
        if (InCar)
        {
            if (Input.GetKeyDown(KeyCode.W))
            {
                transform.Translate(Vector3.forward * accelerationSpeed * Time.deltaTime);
            }
            if (Input.GetKeyDown(KeyCode.S))
            {
                transform.Translate(Vector3.forward * -reverseSpeed * Time.deltaTime);
            }
            if (Input.GetKeyDown(KeyCode.A))
            {
                transform.Rotate(Vector3.up, -turnSpeed * Time.deltaTime);
            }
            if (Input.GetKeyDown(KeyCode.D))
            {
                transform.Rotate(Vector3.up, turnSpeed * Time.deltaTime);
            }
        }
    }

    public void ExitCar()
    {
        
        //transform.position = transform.position;
        //transform.rotation = transform.rotation;
    }
    public void EnterCar(PlayerController playerController)
    {
        playerController.gameObject.SetActive(false);
        InCar = true;
    } 
        
}