using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public GameObject level1UI;
    public GameObject level2UI;
    public GameObject level3UI;
    

    public void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("House"))
        {
            level1UI.SetActive(true);
            Cursor.lockState = CursorLockMode.None;
        }
        if(other.CompareTag("Apartment"))
        {
            level2UI.SetActive(true);
            Cursor.lockState = CursorLockMode.None;
        }
        if(other.CompareTag("Apartment2"))
        {
            level3UI.SetActive(true);
            Cursor.lockState = CursorLockMode.None;
        }
    }

    public void Exit1()
    {
        level1UI.SetActive(false);
        Cursor.lockState = CursorLockMode.Locked;
    }
    public void Exit2()
    {
        level2UI.SetActive(false);
        Cursor.lockState = CursorLockMode.Locked;
    }
    public void Exit3()
    {
        level3UI.SetActive(false);
        Cursor.lockState = CursorLockMode.Locked;
    }


    public void GoToLevel1()
    {
        SceneManager.LoadScene(1);
        Cursor.lockState = CursorLockMode.Locked;
    }
    public void GoToLevel2()
    {
        SceneManager.LoadScene(2);
        Cursor.lockState = CursorLockMode.Locked;
    }
    public void GoToLevel3()
    {
        SceneManager.LoadScene(3);
        Cursor.lockState = CursorLockMode.Locked;
    }


}
