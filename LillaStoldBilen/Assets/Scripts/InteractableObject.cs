using UnityEngine;
using UnityEngine.Events;

public class InteractableObject : MonoBehaviour
{

    public UnityEvent OnInteract;
    
    public void Interact()
    {
        Debug.Log("Interacted with " + gameObject.name);
        OnInteract.Invoke();
    }
}