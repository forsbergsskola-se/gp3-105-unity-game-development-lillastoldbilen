using Unity.Mathematics;
using UnityEngine;

public class Hand : MonoBehaviour
{
    public GameObject equippedItem;
    

    public void Equip(GameObject item)
    {
        item.transform.SetParent(this.transform);
                
        item.transform.localPosition = Vector3.zero;
        item.transform.localRotation = quaternion.identity;
        Destroy(item.GetComponent<Rigidbody>());
    }

    public void UnEquip()
    {
        
    }

    public bool HasEquippedItem()
    {
        return true;
    }

}