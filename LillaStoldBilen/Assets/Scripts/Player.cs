using UnityEngine;


public class Player : MonoBehaviour

{ 
    public Hand rightHand;
    public Hand leftHand;
    
    public int Health = 90;
    public float MovementSpeed;
    public int MoneyBag;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))
            Toggle();
    }
    
    public void CashIn(int money)
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

    public void Toggle()
    {
  
    }
}






/*
void GetHand()
   if(!leftHand.hasequippedItem) return leftHand;
   if(!rightHand.hasequippedItem) return rightHand;
   return null;
*/