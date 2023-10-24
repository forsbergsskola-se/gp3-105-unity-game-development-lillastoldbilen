using Unity.VisualScripting;
using UnityEditor.Build.Content;
using UnityEngine;

public class Orangecarmovement : MonoBehaviour
{
    public float accelerationSpeed = 100f;
    public float turnSpeed = 100f;
    public float reverseSpeed = 100f;
    public bool InCar = false;
    public GameObject Player;
    public FollowPlayer followPlayer;
    public PlayerController playerController;
    private GameObject oldFollowTarget;
    public GameObject exitCarSpawn;
    public void ActivateCar()
    {
        
    }

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
        PlayerController playerController = this.playerController;
        this.playerController = null;
       // get playerController from the field
       // reset the field
       playerController.gameObject.SetActive(true);  // here, undo everything you've done in EnterCar
       InCar = false;
       followPlayer.player = this.oldFollowTarget;
       this.oldFollowTarget = null;
       playerController.gameObject.transform.position = exitCarSpawn.transform.position;
    }
    
    public void EnterCar(PlayerController playerController)
    {
        playerController.gameObject.SetActive(false);
        InCar = true;
        this.oldFollowTarget = followPlayer.player;
        followPlayer.player = this.gameObject; //Camera follows now car
        
        // save playerController to a field
        this.playerController = playerController;
    }
}
