using UnityEngine;
using UnityEngine.Audio;

[System.Serializable]
public class Sound
{

    public string name;

    public AudioClip clip;

    [Range(0f,1f)]
    public float volume;

    [Range(0.1f,3f)]
    public float pitch;

    //true if the sound loops and false if it plays once
    public bool loop;

    //We hide this because it is automatically populated
    // in the Awake method of the Audiomanager.
    [HideInInspector]
    public AudioSource source;

}
