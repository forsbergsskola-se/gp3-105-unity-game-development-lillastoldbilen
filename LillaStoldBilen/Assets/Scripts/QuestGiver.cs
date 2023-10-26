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

/*
public Quest quest;
public GameObject player = GameObject.Find("Player");

public void StartQuest()
{
    Debug.Log("Start Quest", this);
}
*/