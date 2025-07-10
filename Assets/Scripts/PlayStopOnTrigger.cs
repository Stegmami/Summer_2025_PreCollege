using UnityEngine;

public class PlayStopOnTrigger : MonoBehaviour
{


    // Attach this script to a GO
    // Give the GO a collider2D
    // Give the GO an Audiosource with a clip
    // When the GO collides with a GO that has a Collider2D 
    // The clip will play 

    public void OnTriggerEnter2D()
    {
        gameObject.GetComponent<AudioSource>().Play();
    }

    public void OnTriggerExit2D()
    {
        gameObject.GetComponent <AudioSource>().Stop();
    }

}
