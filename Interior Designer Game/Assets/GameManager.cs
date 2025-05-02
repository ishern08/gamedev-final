using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
   public GameObject player;
   public GameObject spawn;
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

       spawn = GameObject.FindWithTag("Respawn");

    }

    void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("House"))
        {
            SceneManager.LoadScene(1);
            if(other.CompareTag("Respawn"))
            {
                player.transform.position = spawn.transform.position;
                Debug.Log(player.transform.position);
            }

        }
        if(other.CompareTag("DoorOutofHouse"))
        {
            SceneManager.LoadScene(0);
        }
    }




}
