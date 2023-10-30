using Unity.Mathematics;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed = 6f;
    public float rotateSpeed = 10f;

    private Rigidbody playerRigidbody;
    public bool OnEnable { get; set; }
    private PlayerHealth playerHealth;
    public bool enable;

    void Start()
    {
        playerRigidbody = GetComponent<Rigidbody>();
    }
    
    void Update()
    {
        float vertical = Input.GetAxisRaw("Vertical");
        playerRigidbody.velocity = transform.forward * vertical * moveSpeed;

        float rotationinput = Input.GetAxis("Horizontal");
        Vector3 rotation = new Vector3(0, rotationinput, 0) * rotateSpeed * Time.deltaTime;
        Quaternion deltaRotation = quaternion.Euler(rotation);
        playerRigidbody.MoveRotation(playerRigidbody.rotation * deltaRotation);
    }
}
