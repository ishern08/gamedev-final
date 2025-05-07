using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour
{
    public GameObject levelFailedUI;
    public GameObject levelPassedUI;
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
        Debug.Log("yay");
    }

    public void restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void BacktoCity()
    {
        SceneManager.LoadScene(0);
    }

    public void MainMenu()
    {
        SceneManager.LoadScene(4);
    }
}
