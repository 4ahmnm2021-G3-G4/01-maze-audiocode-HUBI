using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CollectEgg : MonoBehaviour
{
    [SerializeField] AudioSource playSound;
    [SerializeField] GameData data;
    [SerializeField] Text nbrcollectedEggs;

    bool isTriggered = false;

    void OnTriggerEnter(Collider col)
    {
        if (!isTriggered)
        {
            Debug.Log(gameObject.name + " " + col.name);
            playSound.Play();
            Destroy(gameObject);

            data.collectedEggs++;
            nbrcollectedEggs.text = data.collectedEggs.ToString();
            isTriggered = true;
        }
    }

}
