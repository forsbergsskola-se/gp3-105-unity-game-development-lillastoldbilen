using UnityEngine;


public class Player : MonoBehaviour

{ 
    public Hand rightHand;
    public Hand leftHand;
    public float MovementSpeed;
    private int moneyBag;
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

    private const string MoneyBagKey = "MoneyBag";

    public int MoneyBag
    {
        get
        {
            return PlayerPrefs.GetInt(MoneyBagKey, 0);
        }
        set
        {
            PlayerPrefs.SetInt(MoneyBagKey, value);
        }
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
        if (rightHand.equippedItem == null && leftHand.equippedItem != null)
        {
            rightHand.Equip(leftHand.equippedItem);
            leftHand.equippedItem = null;
        }
        else if (rightHand.equippedItem != null && leftHand.equippedItem == null)
        {
            leftHand.Equip(rightHand.equippedItem);
            rightHand.equippedItem = null;
        }
        GameObject pocket = rightHand.equippedItem;
        rightHand.Equip(leftHand.equippedItem);
        leftHand.Equip(pocket);
    }
}