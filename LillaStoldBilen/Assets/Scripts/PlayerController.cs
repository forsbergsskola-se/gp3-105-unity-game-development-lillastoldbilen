using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 6f;
    
    void Start()
    {
        
    }

    void Update()
    {
        float horizontal = Input.GetAxisRaw("Horizontal");
        float vertical = Input.GetAxisRaw("Vertical");
        GetComponent<Rigidbody>().AddForce(Input.GetAxisRaw("Horizontal") * speed, 0, 0);
        GetComponent<Rigidbody>().AddForce(0, 0, Input.GetAxisRaw("Vertical") * speed);
    }

}
