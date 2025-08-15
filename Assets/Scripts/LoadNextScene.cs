using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadNextDay : MonoBehaviour
{
    
    /// <summary>
    /// Loads the next scene from the build list.
    /// </summary>
    public void LoadNextScene()
    {
        int nextSceneIndex = SceneManager.GetActiveScene().buildIndex + 1;
        SceneManager.LoadScene(nextSceneIndex);
    }

}
