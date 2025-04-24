using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : ScriptableObject
{
   public GameState GameState {get; private set;}
   public string spawnTag;

    /*void OnEnable()
    {
        LevelEvents.levelLoaded +=SpawnPlayer;

        PlayerStats = Instantiate(startingPlayerStats);
    }*/

    protected void SpawnPlayer(Transform spawnTransform)
   {
        if(GameState.playerSpawnLocation != "")
        {
            GameObject[] spawns = GameObject.FindGameObjectsWithTag(spawnTag);
            bool foundSpawn = false;

            foreach(GameObject spawn in spawns)
            {
                if(spawn.name == GameState.playerSpawnLocation)
                {
                    foundSpawn = true;

                    //ActivePlayer = Instantiate(playerPrefab, spawn.transform.position, Quaternion.identity);
                    break;
                }
            }
            if(!foundSpawn)
            {
                throw new MissingReferenceException("Could not find the player spawn location with the name " + GameState.playerSpawnLocation);
            }
        }
        else
        {
            //ActivePlayer = Instantiate(playerPrefab, spawn.transform.position, Quaternion.identity);
            Debug.Log("Player spawned at default location: " + spawnTransform);
        }

        /*if(ActivePlayer)
        {
            PlayerEvents.onePlayerSpawned.Invoke(ActivePlayer.transform);
        }

        else
        {
            throw new MissingReferenceException("No ActivePlayer in PlayerManager. May have failed to Spawn!");
        }
        */
   }
}
