using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
   public GameObject player;

    public static GameManager instance {get; private set;}
    private void Awake()
    {
        if(instance != null && instance != this)
        {
            Destroy(gameObject);
            return;
        }
        else
        {
            instance = this;
            DontDestroyOnLoad(this);
        }

       

    }

    void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("House"))
        {
            SceneManager.LoadScene(1);

        }
        if(other.CompareTag("DoorOutofHouse"))
        {
            SceneManager.LoadScene(0);
        }
    }




}
