using UnityEngine;


public class Player : MonoBehaviour

{ 
    public Hand rightHand;
    public Hand leftHand;
    public float MovementSpeed;
    public int MoneyBag;
    public bool ActiveItem;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))
            Toggle();
        
    }
    
    public void CashIn(int money) //When player is close enough, money adds to the MoneyBag
    {
        MoneyBag += money;
    }

    public Hand GetHand()
    {
        if(!rightHand.equippedItem) return rightHand;
        if(!leftHand.equippedItem) return leftHand;
        Debug.Log("Your hands are full!");
        return null;
    }

    private void Toggle()
    {
        GameObject pocket = rightHand.equippedItem;
        rightHand.Equip(leftHand.equippedItem);
        leftHand.Equip(pocket);
    }

}