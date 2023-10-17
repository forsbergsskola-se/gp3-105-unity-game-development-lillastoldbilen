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
    

    // Update is called once per frame
    void Update()
    {
        
    }
}

