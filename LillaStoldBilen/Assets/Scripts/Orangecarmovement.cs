using UnityEngine;

public class Orangecarmovement : MonoBehaviour
{
    public float moveSpeed;
    public float crashForce;
    public float maxSpeed;
    public float speedForce;

// Start is called before the first frame update
// srat gameloop

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

// update is called one per frame
// Update gameloop
    void update ()
    {
        transform.translate(x:0, y:0, z:1f); // In every frame the car will move 1 along z 
    }
}

// Render : Presenting to the user (computer screen)