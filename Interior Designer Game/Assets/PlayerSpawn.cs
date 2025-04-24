using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSpawn : MonoBehaviour
{
    public GameObject spawn;
    Vector3 pos = new Vector3(0f, 0f, 0f);
    void Awake()
    {
        spawn = GameObject.FindWithTag("Player");
        spawn.transform.position = new Vector3(0f,0f,0f);
        Console.Write(spawn.transform.position);
    }

}
