using UnityEngine;

public class QuestGiver : MonoBehaviour
{
    public Quest quest;
    public Player player;

    public void OnInteract(PlayerInteract playerInteract)
    {
        if (!quest.IsAccepted())
        {
            // The quest has not been started yet, so you can initiate it.
            StartQuest();
        }
        else if (quest.IsCompleted())
        {
            // The quest is completed, so you can allow the player to hand it in.
            HandInQuest(playerInteract);
        }
    }
    
    public void StartQuest()
    {
        quest.StartQuest(); //Add a invoke to InteractableObject

    }

    public void HandInQuest(PlayerInteract playerInteract)
    {
        Player player = playerInteract.GetComponent<Player>();
        if (quest.IsCompleted())
        {
            quest.Finish(player);
        }
    }
}
