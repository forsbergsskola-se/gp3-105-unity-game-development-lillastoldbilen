using DefaultNamespace;
using UnityEngine;
using UnityEngine.UIElements;

public class PlayerController : MonoBehaviour
{
    public Rigidbody rb;
    public Transform player;
    public float horizontalInput;
    public float verticalInput;
    public float turnSpeed = 10;
    // Start is called before the first frame update
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
