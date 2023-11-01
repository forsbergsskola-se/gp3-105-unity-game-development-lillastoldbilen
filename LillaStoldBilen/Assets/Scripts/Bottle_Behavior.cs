using UnityEngine;
using UnityEngine.Events;


public class Bottle_Behavior : MonoBehaviour
{
    public UnityEvent onPickedUp;
    public float bottleHP = 20;
    
    private int RotationSpeed = 100;
    private Transform bottleTransform;
    
    
    //Rotation-animation
    void Start()
    {
        bottleTransform = this.GetComponent<Transform>();
    }
    void Update()
    {
        if (this.gameObject == FindObjectOfType<Player>()?.rightHand?.equippedItem)
        {
            if (Input.GetKeyDown(KeyCode.Mouse0))
            {
                FindObjectOfType<PlayerHealth>().health += bottleHP;
                Destroy(this.gameObject);
            }
        }

        bottleTransform.Rotate(RotationSpeed * Time.deltaTime, 0, 0);
    }
    
    public void OnPickup()
    {
        onPickedUp.Invoke();
    }

}