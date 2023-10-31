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
        item.GetComponent<Rigidbody>().isKinematic = true;
        this.equippedItem = item;
        Destroy(item.GetComponent<Collider>());
    }

    public void UnEquip()
    {
        Destroy(this.gameObject);
    }

    public bool HasEquippedItem()
    {
        return this.equippedItem != null;
    }

}