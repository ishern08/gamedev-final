using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{

    [SerializeField] private Text timerText;
    
    public float startingTime;
    private float timeLeft;
    public float elapsedTime;
    public UIManager uiManager;
    public GameObject furniture;
    


    
       void Start()
    {
        elapsedTime = 0f;
    }

    void Update()
    {
        string countDown = "";
        elapsedTime += Time.deltaTime;
        timeLeft = startingTime - Mathf.RoundToInt(elapsedTime);
        countDown = "Time Left: " + timeLeft.ToString();

        if(elapsedTime > startingTime && GameObject.FindGameObjectWithTag("notInteracted") == null && furniture.activeSelf == true)
        {
            countDown = "Out of Time!";
            uiManager.levelCompleted();
    
            
        }
        else if(elapsedTime > startingTime)
        {
            countDown = "Out of Time!";
       
            uiManager.levelFailed();
            furniture.SetActive(false);
            
            
        }
        

        SetTimerText(countDown);
    }

    private void SetTimerText(string newText)
    {
        if(timerText)
        {
            timerText.text = newText;
        }
    }
}
