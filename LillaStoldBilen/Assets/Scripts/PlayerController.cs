using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public Rigidbody rb;
    public Transform player;
    public float horizontalInput;
    public float verticalInput;
    public float turnSpeed = 10;
    void Start()
    {
        Player player = new Player();
    }

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");
        
        transform.Translate(Vector3.forward * Time.deltaTime * verticalInput);
        transform.Rotate(-Vector3.up * horizontalInput * turnSpeed * Time.deltaTime);
    }
}
