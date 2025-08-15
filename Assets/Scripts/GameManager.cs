using UnityEngine;

/// <summary>
/// Initiates scene transitions.
/// </summary>
public class GameManager : MonoBehaviour
{
    public GameObject completeDayUI;

    public void EndDay()
    {
        Debug.Log("EndDay() is called");
        completeDayUI.SetActive(true);
    }

}
