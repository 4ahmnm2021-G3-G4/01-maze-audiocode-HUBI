using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MyPlayer : MonoBehaviour
{
    private int eggCounter;
    public bool eggCompleted = false;
    public Text scoreText;


    // Start is called before the first frame update
    void Start()
    {
        eggCounter = 0;
    }
     private void OnTriggerEnter(Collider other)
    {
        Debug.Log("gameObject " + gameObject + " other " + other.name);
        if(other.tag == "EasterEgg")
        {
            eggCounter++;
            scoreText.text = "Score: " + eggCounter;
            Debug.Log ("Score:" +eggCounter);
        }
        if(other.tag == "EasterEgg1")
        {
            eggCounter++;
            scoreText.text = "Score: " + eggCounter;
            Debug.Log ("Score:" +eggCounter);
        }
        if(other.tag == "EasterEgg2")
        {
            eggCounter++;
            scoreText.text = "Score: " + eggCounter;
            Debug.Log ("Score:" +eggCounter);
        }
        if(eggCounter == 3)
        {
            eggCompleted = true;
        }
    }

}