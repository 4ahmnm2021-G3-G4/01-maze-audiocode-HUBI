using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerEggSound : MonoBehaviour
{
    public AudioSource playSound;

    void OnTriggerEnter(Collider Egg)
    {
        playSound.Play();
    }

}
