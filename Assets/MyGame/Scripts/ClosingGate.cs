using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClosingGate : MonoBehaviour
{
    public Animator animGate;
    public AudioSource closedoor;
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            closedoor.Play();
            animGate.SetBool("CloseGate", true);
        }
    }
}
