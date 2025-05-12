using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.Timeline;


public class CutsceneManager : MonoBehaviour
{
    PlayableDirector director;
    public TimelineAsset clip1;
    public TimelineAsset clip2;
    public TimelineAsset clip3;
 

   
    void Start()
    {
        director = GetComponent<PlayableDirector>();
    }

    void Update()
    {
       director.Play(clip1);
       director.Play(clip2);
    }

}
