using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    private int eggCounter;
    public bool eggCompleted = false;
    public Text scoreText;
    public AudioSource playSound;

    // Start is called before the first frame update
    void Start()
    {
        eggCounter = 0;
    
    void OnTriggerEnter(Collider other)
    {
        playSound.Play();

        if(other.tag == "EasterEgg")
        {
            eggCounter++;
            scoreText.text = "Score: " + eggCounter;
            Debug.Log ("Score:" +eggCounter);
        }
        if(other.tag == "EasterEgg1")
        {
            eggCounter++;
            Destroy(other.tag == "EasterEgg1");
            scoreText.text = "Score: " + eggCounter;
            Debug.Log ("Score:" +eggCounter);
        }
        if(other.tag == "EasterEgg2")
        {
            eggCounter++;
            Destroy(other.tag == "EasterEgg2");
            scoreText.text = "Score: " + eggCounter;
            Debug.Log ("Score:" +eggCounter);
        }
        if(eggCounter == 3)
        {
            eggCompleted = true;
        }
         
    }
    }
}