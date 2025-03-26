
using UnityEngine;
using UnityEngine.Events;

public class InteractionObject : MonoBehaviour
{
    public UnityEvent onInteract = new UnityEvent();
    [SerializeField] private string interactionText = "I'm an interactable object!";

    private void OnEnable()
    {
        
    }

    public string GetInteractionText()
    {
        return interactionText;
    }

    public void Interact()
    {
        onInteract.Invoke();
    }
}
