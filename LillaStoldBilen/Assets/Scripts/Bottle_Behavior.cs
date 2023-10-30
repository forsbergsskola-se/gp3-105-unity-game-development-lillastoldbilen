using UnityEngine;
using UnityEngine.Events;


public class Bottle_Behavior : MonoBehaviour
{
    public UnityEvent onPickedUp;
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

    
    public void OnPickup()
    {
        onPickedUp.Invoke();
    }

}