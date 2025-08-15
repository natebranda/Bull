using System.Collections;
using UnityEngine;

/// <summary>
/// Used to create child classes that handle the completion of a chore on
/// the attached interactable chore object.
/// </summary>
public class Chore : Feel, IInteractable
{
    public override string InteractMessage => currentInteractMessage;

    /// <summary>
    /// The string that is currently the interact message. 
    /// Changes when chore is complete.
    /// </summary>
    private string currentInteractMessage;

    /// <summary>
    /// The prompt displayed when choreComplete is false
    /// </summary>
    public string chorePrompt;

    /// <summary>
    /// The string name of the chore which will be marked complete
    /// on the ToDoList when the chore is completed.
    /// </summary>
    public string choreName;

    /// <summary>
    /// The time in in-game hours that passes when you complete
    /// this chore.
    /// </summary>
    public int choreDuration;

    /// <summary>
    /// The name of the audio clip that plays when this chore is completed
    /// </summary>
    public AudioSource choreAudio;

    /// <summary>
    /// The ToDoList object in the current scene.
    /// </summary>
    private ToDoList toDo;

    /// <summary>
    /// True when the chore is available to be completed, false when it is 
    /// inactive or has already been completed.
    /// </summary>
    public bool choreActive = false;

    private PlayerMovement playerMovement;

    //Used for initialization
    public void Awake()
    {
        toDo = FindAnyObjectByType<ToDoList>();
        playerMovement = FindAnyObjectByType<PlayerMovement>();
    }

    public override void Interact()
    {

        if (toDo.remainingChores.Contains(choreName))
        {
            currentInteractMessage = chorePrompt;
            //chore can be completed
            choreActive = true;
        }
        else 
        {
            currentInteractMessage = base.InteractMessage;
        }

        //use base interact
        base.Interact();

        if (choreActive)
            StartCoroutine(WaitForE());
    }

    /// <summary>
    /// Called after interacting with a chore object. Waits for
    /// user input to start the associated chore with ChoreSequence
    /// and then mark the chore on this object as complete. If the
    /// player looks away from this object, this method will be
    /// exited without any further effect.
    /// </summary>
    /// <returns></returns>
    IEnumerator WaitForE()
    {
        //access Interaction controller
        InteractionController IC = FindAnyObjectByType<InteractionController>();
        IInteractable thisInteractable = GetComponent<IInteractable>();

        //wait for E to be pressed and this object to be targeted
        while (!Input.GetKeyDown(KeyCode.E))
        {
            //Determine whether this object is the currently targeted interactable
            bool isCurrentInteractable = IC.currentTargetedInteractable == thisInteractable;

            //If this object has been looked away from, exit the coroutine
            if (!isCurrentInteractable)
            {
                yield break;
            }

            //wait until next frame and then keep looping in this while block
            yield return null;
        }

        //E was pressed, so we start the chore cutscene
        StartCoroutine(ChoreSequence());

        toDo.MarkChoreComplete(choreName);
        toDo.PassTime(choreDuration);
        choreActive= false;
        //Change interact message back to standard feel text
        currentInteractMessage = base.InteractMessage;
        //exit coroutine
        yield break;
    }

    /// <summary>
    /// This method will run the audio cutscene representing the completion
    /// of this object's chore.
    /// </summary>
    IEnumerator ChoreSequence()
    {
        playerMovement.enabled = false;
        //Reset to disable InteractUI
        base.Reset();

        AudioClip ChoreClip = choreAudio.clip;
        choreAudio.Play();

        //Wait for the duration of the Chore audio clip before exiting
        yield return new WaitForSeconds(ChoreClip.length);

        playerMovement.enabled = true;
    }
}
