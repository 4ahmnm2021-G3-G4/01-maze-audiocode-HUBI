using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LevelManager : MonoBehaviour



{
    public Player play;
    public Animator animDoor;
    void Start()
    {
        
    }

    
    void Update()
    {
        if(play.eggCompleted == true){
            animDoor.SetBool("Collected", true);
        }
    }
}

