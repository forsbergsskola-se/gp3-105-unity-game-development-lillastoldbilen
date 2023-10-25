using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UIElements;

public class Quest : MonoBehaviour
{
    public UnityEvent QuestStartedEvent;
    public UnityEvent CopKilledEvent;
    
    private bool isAccepted;
    private bool copKilled; 
    

    public void StartQuest()
    {
        if (this.isAccepted)
        {
            return;
        }
        this.isAccepted = true;
        this.QuestStartedEvent.Invoke();
    }

    public bool IsAccepted()
    {
        return this.isAccepted;
    }

    public bool GetCopKilled()
    {
        return this.copKilled;
    }
    public void OnCopKilled()
    {
        if (!isAccepted)
        {
            return;
        }
        this.copKilled = true;
        this.CopKilledEvent.Invoke();
    }
}
