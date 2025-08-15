using UnityEngine;
using UnityEngine.Audio;
using System;

/// <summary>
/// NOTE: Use only for sounds not attached to specific
/// game objects.
/// 
/// Manages all sounds and audio for the game. Sounds can be added to
/// the Sounds array through the inspector. Sounds can be played using
/// FindAnyObjectByType<AudioManager>().Play("nameOfSound") to play
/// the sound with the given name.
/// </summary>
public class AudioManager : MonoBehaviour
{
    /// <summary>
    /// Array of all sounds in the game.
    /// </summary>
    public Sound[] sounds;

    /// <summary>
    /// The sound currently being played by the AudioManager.
    /// </summary>
    private Sound currentSound;

    /// <summary>
    /// The current instance of this object. 
    /// </summary>
    public static AudioManager instance;

    //Awake is used for initialization (before the Start method)
    private void Awake()
    {
        if (instance == null)
        {
            //create instance
            instance = this;
        }
        else
        {
            //destroy extra instance
            Destroy(gameObject);
            //ensure no other code is called before destoying this object
            return;
        }

        //ensures that the AudioManager survives between scene transitions
        //by placing it within the DontDestroyOnLoad scene.
        DontDestroyOnLoad(gameObject);


        foreach (Sound s in sounds)
        {
            s.source = gameObject.AddComponent<AudioSource>();
            s.source.clip = s.clip;

            s.source.volume = s.volume;
            s.source.pitch = s.pitch;
            s.source.loop = s.loop;
        }
    }

    /// <summary>
    /// Searches for the sound with the given name and plays it. If there was
    /// already a sound playing from the AudioManager, it is replaced with the
    /// new sound.
    /// </summary>
    /// <param name="name">the name of the sound we want to play.</param> 
    public void Play (string name)
    {
        //In the sounds array, find a sound so that the name of that sound is equal
        //to the name parameter (lambda expression).
        Sound s = Array.Find(sounds, sound => sound.name == name);
        
        //if the sound with the given name is not found, do nothing
        if (s == null)
        {
            Debug.LogWarning("Sound:  " + name + "  not found!");
            return; 
        }

        //replace currentSound if necessary
        if (currentSound != null)
        {
            currentSound.source.Stop();
        }

        currentSound = s;
        s.source.Play();
    }
}
