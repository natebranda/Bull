using UnityEngine;

/// <summary>
/// This script ensures that the sound clip with the given name plays
/// when the player or a person collides with this object.
/// 
/// Note: Floor tiles should be at (0.5 x, 1 y, 0.5 z) scale to 
/// prevent the player from touching two blocks at once and making
/// the sound play twice.
/// </summary>
public class SteppedOn : MonoBehaviour
{

    //This object as an audio source
    public AudioSource audioSource;

    void OnCollisionEnter(Collision collisionInfo)
    {

        if (collisionInfo.collider.tag == "Player" | 
            collisionInfo.collider.tag == "Person")
        {
            //Play stored clip from this object
            audioSource.Play();
        }
    }

}
