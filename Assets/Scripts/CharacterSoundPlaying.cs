using UnityEngine;

public class CharacterSoundPlaying : MonoBehaviour
{
    // this class should be attached to the player's character
    // This class could also be used on any GO that might collide with things for which we want to hear sounds

    // We need a reference to the SoundFX class that is in our scene
    public SoundFX MySoundFX;
    public AudioSource MyAudioSource;
    public SOUNDFILESHERE sOUNDFILESHERE;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision == null) return;

        if (collision.gameObject.tag == "enemy")
        {
            // print("Hit Enemy!!");

            MyAudioSource.PlayOneShot(MySoundFX.CollisionWithEnemy);

        }
        if (collision.gameObject.tag =="friend")
        {
            // print("Hit Friend");
        }

        if (collision.gameObject.tag == "wall")
        {
            // print("hit Wall");
        }
    }




}
