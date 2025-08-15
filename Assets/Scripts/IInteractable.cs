/// <summary>
/// Interface for interactable objects. More specifically, it is used
/// for all objects that respond to player raycasts.
/// </summary>
public interface IInteractable
{
    /// <summary>
    /// The message displayed by the interactable
    /// </summary>
    public string InteractMessage { get; }

    /// <summary>
    /// The code that runs when the player is adjacent to and
    /// looking at the interactable
    /// </summary>
    public void Touch();

    /// <summary>
    /// The code that runs when the player interacts with the interactable
    /// </summary>
    public void Interact();

    /// <summary>
    /// Resets the interactable to its original state and prepares
    /// the UI for future use of the Interact method
    /// </summary>
    public void Reset();
}
