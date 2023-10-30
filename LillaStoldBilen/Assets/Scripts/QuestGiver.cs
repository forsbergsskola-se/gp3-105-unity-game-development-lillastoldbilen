using UnityEngine;

public class QuestGiver : MonoBehaviour
{
    public Quest quest;
    public Player player;

    public void OnInteract(PlayerInteract playerInteract)
    {
        // sometimes invoke start quest

        // sometimes invoke hand in quest
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
