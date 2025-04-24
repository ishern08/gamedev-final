using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public GameObject Player;
    public static GameManager instance;

    private void Awake()
    {
        if(instance)
        {
            Destroy(this);
        }
        else
        {
            instance = this;
            DontDestroyOnLoad(this);
        }
    }


    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "House")
        {
            SceneManager.LoadScene(1);
           
           
        }

        if(other.tag == "DoorOutofHouse")
        {
            SceneManager.LoadScene(0);
          
            
        }

        if(other.tag == "Apartment")
        {
            SceneManager.LoadScene(2);
        }

        if(other.tag == "DoorOutofApartment")
        {
            SceneManager.LoadScene(0);
     
          
        }

        if(other.tag == "Apartment2")
        {
            SceneManager.LoadScene(3);
        }

        if(other.tag == "DoorOutofApartment2")
        {
            SceneManager.LoadScene(0);
         
        }
    }
}
