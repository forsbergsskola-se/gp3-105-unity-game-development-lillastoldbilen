using UnityEngine;

public class Orangecarmovement : MonoBehaviour
{
    public float accelerationSpeed = 1f; // just random numbers for start: i will change it later 
    public float turnSpeed = 0.5f;
    public float reverseSpeed = 1f;
    public float brakeSpeed = 1f;
    private bool InCar = false; // It changed automatically to private here

    void Update()
    {
       if (Input.GetKeyDown(KeyCode.E) && !InCar) // I used the same key to enter and excite the car (E)
       {
           EnterCar(); // I will write a method later int the code 
       }
       if (Input.GetKeyDown(KeyCode.E) && InCar)
       {
           ExitCar(); // I will write a methode later in the code (I need to think first)
       }
       if(InCar)
       {
           {
               if (Input.GetKeyDown(KeyCode.W))
               {
                   car.transform.translate(Vector3.forward * accelerationSpeed * Time.deltaTime);
               }
               if(Input.GetKeyDown(KeyCode.S))
               {
                   Car.transform.translate(Vector3.forward * -brakeSpeed * Time.deltaTime);
               }
               if (Input.GetKeyDown(KeyCode.A))
               {
                   car.transform.Rotate(Vector3.)
               }
           }
       }
    }
    


