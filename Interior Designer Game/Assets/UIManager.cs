using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour
{
    public GameObject levelFailedUI;
    public GameObject levelPassedUI;
    private bool lev1 = false;
    private bool lev2 = false;
    private bool lev3 = false;



    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void levelFailed()
    {
        levelFailedUI.SetActive(true);
        Cursor.lockState = CursorLockMode.None;
        
    }

    public void levelCompleted()
    {
        levelPassedUI.SetActive(true);
        Cursor.lockState = CursorLockMode.None;
        
    }

    public void restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void BacktoCity()
    { 
        SceneManager.LoadScene(0);
        Cursor.lockState = CursorLockMode.Locked;
    }

    public void Back2City()
    {
        SceneManager.LoadScene(7);
        Cursor.lockState = CursorLockMode.Locked;
    }

    public void MainMenu()
    {
        SceneManager.LoadScene(4);
    }
}
