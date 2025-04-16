using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{


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
    }
}
