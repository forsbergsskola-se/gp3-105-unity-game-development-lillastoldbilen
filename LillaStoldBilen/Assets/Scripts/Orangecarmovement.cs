using UnityEngine;

public class Orangecarmovement : MonoBehaviour
{
    public float moveSpeed;
    public float crashForce;
    public float maxSpeed;
    public float speedForce;

    // Start is called before the first frame update
    void Start()
    {

        transform.Translate(0, 0, moveSpeed * Time.deltaTime);
        Rigidbody rigidbody = GetComponent<Rigidbody>();
        rigidbody.AddForce(0, 0, speedForce);
        rigidbody.AddForce(0, 0, maxSpeed);
        rigidbody.angularVelocity = new Vector3(0, 0, 0);
    }

    bool IstouchingTheGround()
    {
        int layerMask = LayerMask.GetMask("Ground");
        return Physics.CheckBox(transform.position, transform.lossyScale / 1.99f, transform.rotation, layerMask);
    }
}