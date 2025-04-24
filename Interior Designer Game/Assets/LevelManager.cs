using System;
using System.Collections;
using System.Collections.Generic;
using System.IO.Enumeration;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;

[CreateAssetMenu(fileName = "LevelManager", menuName = "ScriptableObjects/Manager/LevelManager", order = 1)]
public class LevelManager : ScriptableObject
{
    public GameState GameState {get; private set;}

    private void OnLevelExit(SceneAsset nextLevel, String playerSpawnTransformName)
    {
        GameState.playerSpawnLocation = playerSpawnTransformName;
        SceneManager.LoadScene(nextLevel.name, LoadSceneMode.Single);
    }
    
}
    

