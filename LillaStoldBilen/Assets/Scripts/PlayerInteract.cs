using UnityEngine;

public class PlayerInteract : MonoBehaviour
{
    public float interactionRange = 2.0f;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            CheckForInteractable();
        }
    }

    void CheckForInteractable()
    {
        Vector3 playerPosition = transform.position;

        RaycastHit hit;
        if (Physics.Raycast(playerPosition, transform.forward, out hit, interactionRange))
        {
            InteractableObject interactable = hit.collider.GetComponent<InteractableObject>();
            if (interactable != null)
            {
                interactable.Interact();
            }
        }
    }
}