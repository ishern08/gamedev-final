using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.UI;

public class PlayerInteraction : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] private float maxDistance = 5f;
    [SerializeField] private Text interactableName;
    private InteractionObject targetInteraction;

    

    // Update is called once per frame
    void Update()
    {
        Vector3 origin = Camera.main.transform.position;
        Vector3 direction = Camera.main.transform.forward;
        RaycastHit raycastHit = new RaycastHit();
        string interactionText = "";
        targetInteraction = null;

        if(Physics.Raycast(origin, direction, out raycastHit, maxDistance))
        {
            targetInteraction = raycastHit.collider.gameObject.GetComponent<InteractionObject>();
        }
        
        if(targetInteraction)
        {
            interactionText = targetInteraction.GetInteractionText();
        }

        SetInteractableNameText(interactionText);

        
    }

    private void SetInteractableNameText(string newText)
    {
        if(interactableName)
        {
            interactableName.text = newText;
        }
    }

    public void TryInteract()
    {
        if(targetInteraction)
        {
            targetInteraction.Interact();
            gameObject.tag = "alreadyInteracted";
        }
    }

   
}