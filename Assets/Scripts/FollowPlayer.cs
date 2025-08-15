using UnityEngine;

/// <summary>
/// Ensures that the camera is at the same position as the player
/// and faces the same direction as the player each frame.
/// </summary>
public class FollowPlayer : MonoBehaviour
{
    public Transform player;

    // Update is called once per frame
    void Update()
    {

        transform.position = player.position;
        transform.rotation = player.rotation;

    }
}
