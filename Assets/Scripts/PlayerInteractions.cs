using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerInteractions : MonoBehaviour
{
    [SerializeField] private float maxDistance = 2f;
    [SerializeField] private Text interactibleName;

    private InteractionObject targetInteraction;
    

    void Update()
    {
        Vector3 origin = Camera.main.transform.position;
        Vector3 direction = Camera.main.transform.forward;
        RaycastHit raycastHit = new RaycastHit();
        string interactionText = "";
        targetInteraction = null;
        if (Physics.Raycast(origin, direction, out raycastHit, maxDistance))
        {
            interactionText = raycastHit.collider.gameObject.name;
            targetInteraction = raycastHit.collider.gameObject.GetComponent<InteractionObject>();
        }

        if (targetInteraction)
        {
            interactionText = targetInteraction.GetInteractionText();
        }
        SetInteractableNameText(interactionText);
    }
    private void SetInteractableNameText(string newText)
    {
        if (interactibleName)
        {
            interactibleName.text = newText;
        }
    }
}
