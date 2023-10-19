using Unity.Mathematics;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed = 6f;
    public float rotateSpeed = 10f;

    private Rigidbody playerRigidbody;
    public bool OnEnable { get; set; }

    void Start()
    {
        playerRigidbody = GetComponent<Rigidbody>();
    }

    void Update()
    {
            // enter car
        float horizontal = Input.GetAxisRaw("Horizontal");
        float vertical = Input.GetAxisRaw("Vertical");
        Vector3 localForward = transform.forward;
        Vector3 moveDirection = (localForward * vertical + transform.right * horizontal).normalized;
        Vector3 movement = moveDirection * moveSpeed * Time.deltaTime;
        playerRigidbody.MovePosition(transform.position + movement);

        float rotationinput = Input.GetAxis("Horizontal");
        Vector3 rotation = new Vector3(0, rotationinput, 0) * rotateSpeed * Time.deltaTime;
        Quaternion deltaRotation = quaternion.Euler(rotation);
        playerRigidbody.MoveRotation(playerRigidbody.rotation * deltaRotation);
    }

}
