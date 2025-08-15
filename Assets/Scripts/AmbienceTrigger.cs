using UnityEngine;

/// <summary>
/// This script changes the ambient track that is playing when the player enters 
/// the attached trigger object.
/// </summary>
public class AmbienceTrigger : MonoBehaviour
{
    public string AmbientSoundName;

    private void OnTriggerEnter(Collider other)
    {
        FindAnyObjectByType<AudioManager>().Play(AmbientSoundName);
    }

}
