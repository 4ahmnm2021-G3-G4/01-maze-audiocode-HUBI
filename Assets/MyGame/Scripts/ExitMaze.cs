using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExitMaze : MonoBehaviour
{
    public Player play;
    public Animator animExit;
    public Animator secretExit;
    public AudioSource doorOpen;

        
    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Key")
        {
            animExit.SetBool("Entering", true);
            secretExit.SetBool("SecretOpen", true);
            doorOpen.Play();
        }
    }
}
