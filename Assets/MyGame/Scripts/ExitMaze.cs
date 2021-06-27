using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExitMaze : MonoBehaviour
{
    public MyPlayer play;
    public Animator animExit;
    public AudioSource doorOpen;

        
    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Key")
        {
            animExit.SetBool("Entering", true);
            doorOpen.Play();
        }
    }
}
