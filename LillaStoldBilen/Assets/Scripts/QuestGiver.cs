using UnityEngine;

public class QuestGiver : MonoBehaviour
{
    public Quest quest;
    public Player player;
    
    public void StartQuest()
    {
        quest.StartQuest(); //Add a invoke to InteractableObject

    }
}
