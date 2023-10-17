using DefaultNamespace;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public Rigidbody rb;
    public Transform player;
    public float speed = 10f;
    
    // Start is called before the first frame update
    void Start()
    {
        Player player = new Player();
    }

    // Update is called once per frame
    void Update()
    {
        rb = gameObject.GetComponent<Rigidbody>();
        rb.velocity = new Vector3(speed, speed, speed);
    }
}
