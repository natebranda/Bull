using UnityEngine;

/// <summary>
/// This script ensures that when this trigger object is entered or exited
/// A door closing or opening sound plays.
/// </summary>
public class OpenAndCloseDoor : MonoBehaviour
{
    public AudioSource audioSourceOpenDoor;

    public AudioSource audioSourceCloseDoor;

    private void OnTriggerEnter(Collider other)
    {
        audioSourceOpenDoor.Play();
    }

    private void OnTriggerExit(Collider other)
    {
        audioSourceCloseDoor.Play();
    }
}
