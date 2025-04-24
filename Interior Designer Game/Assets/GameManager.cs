using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager instance {get; private set;}
    
    [SerializeField]
    
    private GameState startingState;

    public GameState GameState {get; private set;}
    
    public LevelManager levelManager;


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
    

        GameState = Instantiate(startingState);
        //levelManager.GameState = GameState;
    }

    
}
