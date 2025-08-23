using UnityEngine;
using UnityEngine.SceneManagement;

/// <summary>
/// This script handles the operations that activate when the pause menu
/// buttons are pressed. It also handles the opening and closing of the
/// pause menu. It is listed as CustomPauseMenu because Unity MonoBehavior
/// already defines PauseMenu and thus throws an error unless I change it.
/// </summary>
public class CustomPauseMenu : MonoBehaviour
{

    public GameObject PauseMenuUI;

    //If the pause menu UI is active or not/
    private bool MenuIsActive;

    private PlayerMovement playerMovement;

    public GameObject MiddleInteractionText;

    //used for initialization
    private void Awake()
    {
        MenuIsActive = false;
        playerMovement = FindAnyObjectByType<PlayerMovement>();
    }

    /// <summary>
    /// Checks if player has pressed the escape key and activates
    /// the Pause Menu UI if so. 
    /// </summary>
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape) && !MenuIsActive)
        {
            playerMovement.enabled = false;
            MiddleInteractionText.SetActive(false);
            PauseMenuUI.SetActive(true);
            MenuIsActive = true;
        }
        else if (Input.GetKeyDown(KeyCode.Escape) && MenuIsActive)
        {
            ResumeGame();
        }
    }

    /// <summary>
    /// Loads the Main Menu scene.
    /// </summary>
    public void QuitToMainMenu() 
    {
        SceneManager.LoadScene("Main Menu");
    }

    /// <summary>
    /// Exits the pause menu by deactivating the pause menu UI.
    /// </summary>
    public void ResumeGame()
    {
        playerMovement.enabled = true;
        MenuIsActive = false;
        PauseMenuUI.SetActive(false);
    }

}
