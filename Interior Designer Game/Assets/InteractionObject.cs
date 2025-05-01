using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class InteractionObject : MonoBehaviour
{
    [SerializeField] private string interactionText = "I'm an interactable object!";

    public GameObject gameObject;

    public UnityEvent OnInteract = new UnityEvent();

    private void OnEnable()
    {
        
    }
    public string GetInteractionText()
    {
        return interactionText;
    }

    public void Interact()
    {   if(!gameObject.CompareTag("alreadyInteracted"))
        {
            OnInteract.Invoke();
            gameObject.tag = "alreadyInteracted";
        }
        
    }
}
