using UnityEngine;
using UnityEngine.Events;

public class CopKillQuest : MonoBehaviour
{
    public UnityEvent StartQuestEvent;
    public UnityEvent CopsKilledChangeEvent;

    private bool isAccepted;
    private bool copKilled;

    public bool IsAccepted()
    {
        return this.isAccepted;
    }
}