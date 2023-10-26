using UnityEngine;
using UnityEngine.Events;

public class InteractableObject : MonoBehaviour
{

    public UnityEvent OnInteract;
    public Quest quest;
    
    public void Interact()
    {
        Debug.Log("Interacted with " + gameObject.name);
        OnInteract.Invoke();
    }

    public void StartQuest()
    {
        quest.StartQuest();
    }
}