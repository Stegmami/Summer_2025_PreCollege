using UnityEngine;

public class PlayOnCollision2D : MonoBehaviour
{

    // Attach this script to a GO
    // Give the GO a collider2D
    // Give the GO an Audiosource with a clip
    // When the GO collides with a GO that has a Collider2D 
    // The clip will play 

    public void OnCollisionEnter2D(Collision2D collision)
    {
        gameObject.GetComponent<AudioSource>().Play();

    }
}
