
using UnityEngine;

public class InteractionObject : MonoBehaviour
{
    [SerializeField] private string interactionText = "I'm an interactable object!";

    public string GetInteractionText()
    {
        return interactionText;
    }
}
