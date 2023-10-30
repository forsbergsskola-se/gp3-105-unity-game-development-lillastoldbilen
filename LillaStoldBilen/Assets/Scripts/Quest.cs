using UnityEngine;
using UnityEngine.Events;


public class Quest : MonoBehaviour
{
    public UnityEvent QuestStartedEvent;
    public UnityEvent CopKilledEvent;
    public UnityEvent FinishEvent;
    
    private bool isAccepted;
    private bool copKilled;
    public int dollarReward;
    private bool isHandedIn;
    

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

    public bool IsCompleted()
    {
        return this.copKilled;
    }

    public bool IsFinished()
    {
        return isHandedIn;
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

    public void Finish(Player player)
    {
        if (copKilled && !isHandedIn) // Check if the quest is completed and not already handed in.
        {
            player.CashIn(dollarReward);
            isHandedIn = true; // Mark the quest as handed in.
            FinishEvent.Invoke();
        }
        
    }
}
