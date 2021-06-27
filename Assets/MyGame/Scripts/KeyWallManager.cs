using UnityEngine;

public class KeyWallManager : MonoBehaviour
{
    [SerializeField] GameData data;
    public Animator animDoor;
    public AudioSource doorSound;
    
    void Update()
    {
        if(data.ThreeEggsCollected()){
            doorSound.Play();
            animDoor.SetBool("Collected", true);
        }
    }
}

