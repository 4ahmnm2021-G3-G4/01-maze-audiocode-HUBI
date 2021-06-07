using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    private int eggCounter;
    public Text scoreText;

    // Start is called before the first frame update
    void Start()
    {
        eggCounter = 0;
    }
    void OnTriggerEnter(Collider Egg)
    {
        if(Egg.tag == "EasterEgg")
        {
            eggCounter++;
            Destroy(Egg.gameObject);
            scoreText.text = "Score: " + eggCounter;
            Debug.Log ("Score:" +eggCounter);
        }
    }
}
