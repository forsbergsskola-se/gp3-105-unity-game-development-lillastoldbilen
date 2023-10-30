using UnityEngine;


public class Player : MonoBehaviour

{ 
    public Hand rightHand;
    public Hand leftHand;
    public float MovementSpeed;
    public int MoneyBag;

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
        if(!leftHand.equippedItem) return leftHand;
        if(!rightHand.equippedItem) return rightHand;
        Debug.Log("Your hands are full!");
        return null;
    }

    private void Toggle()
    {
        
    }
    
}