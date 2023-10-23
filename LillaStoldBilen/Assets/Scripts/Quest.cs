using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Quest : MonoBehaviour
{
    public string questName;
    public string questDescription;
    public bool isAccepted;

    public Quest(string name, string description)
    {
        questName = name;
        questDescription = description;
        isAccepted = false;
    }

    public void AcceptQuest()
    {
        isAccepted = true;
    }
    
}
