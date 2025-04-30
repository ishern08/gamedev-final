using System;
using System.Runtime.CompilerServices;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class Objective : MonoBehaviour
{
    [SerializeField] private Text objectiveDisplay;
    [SerializeField] private String objectiveText = "im objective";
    [SerializeField] private string completedText = "im done";

    public UnityEvent OnCompleteObjective = new UnityEvent();

    private void OnEnable()
    {
        objectiveDisplay.text = objectiveText;
    }

    public void CompleteObjective()
    {
        if(gameObject.activeSelf)
        {
            objectiveDisplay.text = "";
            OnCompleteObjective.Invoke();
            gameObject.SetActive(false);
        }
    }
}
