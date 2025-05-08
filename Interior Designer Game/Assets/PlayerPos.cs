using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerPos : MonoBehaviour
{
    public GameObject player;
    Vector3 housepos = new Vector3(-76f, 1.75f, 36);
    Vector3 intoHousepos = new Vector3(0,1.75f,0);

    void Awake()
    {
        Scene scene = SceneManager.GetActiveScene();
        if(scene.name == "Sample Scene")
        {
            player.transform.position = housepos;
            Debug.Log("okay");
        }
         if(scene.name == "House 1")
        {
            player.transform.position = intoHousepos;
            Debug.Log("is being called");
        }
       
    }
}
