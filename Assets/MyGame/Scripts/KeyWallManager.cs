using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class KeyWallManager : MonoBehaviour
{
    public Player play;
    public Animator animDoor;
    public AudioSource doorSound;
    
    void Update()
    {
        if(play.eggCompleted == true){
            doorSound.Play();
            animDoor.SetBool("Collected", true);
        }
    }
}

