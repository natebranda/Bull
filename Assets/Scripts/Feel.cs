using UnityEngine;

/// <summary>
/// This script handles player interactions with this interactable
/// game object by working with the InteractionController class.
/// </summary>
public class Feel : MonoBehaviour, IInteractable
{
    //The text to be displayed on the UI canvas
    virtual public string InteractMessage => objectInteractMessage;

    //The text displayed when the player Interacts with this object
    [SerializeField]
    string objectInteractMessage;

    //The UI object on which the text appears when the interaction happens
    public GameObject InteractUI;

    //Audio source on this object for the touch object SFX
    public AudioSource audioSourceTouch;

    //Audio source on this object for the feel object SFX 
    //public AudioSource audioSourceFeel;
    //^^^ !!- Commented out as I am prioritizing other features over additional noises for objects -!!

    /// <summary>
    /// Runs the touch audio clip specified for this object. Called
    /// when the player is adjacent to and looking at the object
    /// </summary>
    public void Touch()
    {
        audioSourceTouch.Play();
    }

    /// <summary>
    /// Runs when this object is interacted with.
    /// </summary>
    virtual public void Interact()
    {
        //Play audio
        //audioSourceFeel.Play();
        //^^^ !!- Commented out as I am prioritizing other features over additional noises for objects -!!
        //Fade in text
        InteractUI.SetActive(true);
    }

    /// <summary>
    /// Used when this object is no longer the currently targeted interactable.
    /// Deactivates the UI so it can be reactivated with its fade in animation
    /// and resets its text to the interaction prompt.
    /// </summary>
    public void Reset()
    {
        InteractUI.SetActive(false);
    }

}
