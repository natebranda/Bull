using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class InteractionController : MonoBehaviour
{
    
    private Camera playerCamera;

    public TextMeshProUGUI interactionText;

    //The lighter screen that is activated when an object is in front
    public GameObject ObjectAheadScreen;

    public float interactionDistance;

    public IInteractable currentTargetedInteractable;

    //saved for the purpose of resetting object before it is forgotten
    IInteractable previousTargetedInteractable;

    //Awake is used for initialization
    private void Awake()
    {
        //There is only ever one camera, and had trouble attaching in inspector
        playerCamera = FindAnyObjectByType<Camera>();
    }

    //Update is called once each frame
    public void Update()
    {
        //save targeted interactable before it is potentially reset
        previousTargetedInteractable = currentTargetedInteractable;

        UpdateCurrentInteractable();

        if (currentTargetedInteractable == null)
        {
            //fade in lighter screen to indicate no object is ahead
            ObjectAheadScreen.SetActive(true);
        }
        else
        {
            ObjectAheadScreen.SetActive(false);
        }

        //On looking at a new interactable
        if (previousTargetedInteractable != currentTargetedInteractable
            && currentTargetedInteractable != null)
        {
            currentTargetedInteractable.Touch();
        }
            

        //On looking away from an interactable
        if (previousTargetedInteractable != currentTargetedInteractable
            && previousTargetedInteractable != null)
        {
            //Deactivate UI and reset the last interactable
            previousTargetedInteractable.Reset();
        }

        UpdateInteractionText();

        CheckForInteractionInput();
    }

    /// <summary>
    /// Casts a ray from the center of the player camera view, sets the 
    /// the object that the ray is currently pointing to as the 
    /// currentlyTargetedInteractable.
    /// </summary>
    private void UpdateCurrentInteractable()
    {
        //create ray emerging from the center of the player camera
        //(the point located at 0.5 screens on the x and 0.5 screens on the y)
        var ray = playerCamera.ViewportPointToRay(new Vector2(0.5f, 0.5f));

        //shortens ray to interactionDistance, stores 1st object hit by the ray
        Physics.Raycast(ray, out var hit, interactionDistance);

        //store 1st object hit by ray as variable.
        //(? ensures that null is stored if nothing is hit by the ray)
        currentTargetedInteractable = hit.collider?.GetComponent<IInteractable>();
    }

    /// <summary>
    /// Sets the currentTargetedInteractable to the game object the player is
    /// looking at and updates the UI text to that object's InteractPrompt. 
    /// If no interactable object is being looked at, currentTargetedInteractable
    /// is instead set to null. 
    /// </summary>
    private void UpdateInteractionText()
    {
        if (currentTargetedInteractable == null)
        {
            interactionText.text = string.Empty;
            return;
        }

        //update text
        interactionText.text = currentTargetedInteractable.InteractMessage;
    }

    /// <summary>
    /// Checks for player input and ensures the currentTargetedInteractable
    /// is not null before calling its interact method.
    /// </summary>
    private void CheckForInteractionInput()
    {
        if (Input.GetKeyDown(KeyCode.Space) && currentTargetedInteractable != null)
        {
            currentTargetedInteractable.Interact();
        }
    }

}
