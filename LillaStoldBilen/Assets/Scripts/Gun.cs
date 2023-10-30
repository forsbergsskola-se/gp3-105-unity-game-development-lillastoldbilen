using UnityEngine;
using UnityEngine.Events;

public class Gun : MonoBehaviour
{
    public UnityEvent onPickedUp;
    
    public int magazin = 10;
    public GameObject Bullet;
    
    public float BulletSpeed = 100f;

    public Player player;
    
    void Update()
    {
        if(this.gameObject)
        
        if (Input.GetKeyDown(KeyCode.R))
        {
            Invoke("Reload", 2); // Reload Cooldown
        }

        if (isShooting && magazin > 0)
        {
            GameObject newBullet = Instantiate(Bullet, this.transform.position + new Vector3(0, 0, 1),
                this.transform.rotation);
            Rigidbody BulletRB = newBullet.GetComponent<Rigidbody>();
            BulletRB.velocity = this.transform.forward * BulletSpeed;
            magazin--;
        }
        else if (magazin == 0 && isShooting)
            Debug.Log("Magazin is empty");
    }

    public void Reload() 
    { 
        magazin = 10; 
        Debug.Log("Gun is reloaded"); 
    }
    public void OnPickup()
    {
        onPickedUp.Invoke();
    }
}