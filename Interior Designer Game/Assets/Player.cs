using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Player : MonoBehaviour
{

   public static Player instance;
   public GameObject respawn;
   public GameObject player;

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

        respawn = GameObject.FindWithTag("Respawn");
        player.transform.position = respawn.transform.position;
        
        
    }
}

   
