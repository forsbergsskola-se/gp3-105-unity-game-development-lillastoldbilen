using UnityEngine;
using UnityEngine.Events;

public class InteractableObject : MonoBehaviour
{

    public UnityEvent<PlayerInteract> OnInteract;
    public Quest quest;
    
    public void Interact(PlayerInteract player)
    {
        Debug.Log("Interacted with " + gameObject.name);
        OnInteract.Invoke(player);
    }

    public void StartQuest()
    {
        quest.StartQuest();
    }
    
}