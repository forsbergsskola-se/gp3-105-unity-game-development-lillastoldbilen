using UnityEngine;
using UnityEngine.Events;
using UnityEngine.Serialization;

public class Gun : MonoBehaviour
{
    public int magazin = 10;
    public GameObject Bullet;
    
    public float BulletSpeed = 100f;
    public bool UseThisItem;
    
    void Update()
    {
        if (this.gameObject == FindObjectOfType<Player>().rightHand.equippedItem)
        {
            UseThisItem |= Input.GetKeyDown(KeyCode.Mouse0);

            if (Input.GetKeyDown(KeyCode.R))
            {
                Invoke("Reload", 2); // Reload Cooldown
            }

            if (UseThisItem && magazin > 0)
            {
                GameObject newBullet = Instantiate(Bullet, this.transform.position + new Vector3(0, 0, 1),
                    this.transform.rotation);
                Rigidbody BulletRB = newBullet.GetComponent<Rigidbody>();
                BulletRB.velocity = this.transform.forward * BulletSpeed;
                magazin--;
            }
            else if (magazin == 0 && UseThisItem)
                Debug.Log("Magazin is empty");
            
            UseThisItem = false;
        }
    }

    public void Reload() 
    { 
        magazin = 10; 
        Debug.Log("Gun is reloaded"); 
    }
}