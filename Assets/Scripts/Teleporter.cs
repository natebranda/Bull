using UnityEngine;

/// <summary>
/// Facilitates the teleportation of the player to the assigned coordinate
/// position when the player collides with this object. 
/// </summary>
public class Teleporter : MonoBehaviour
{
    //The coordinates you are teleported to
    public Vector3 destination;

    public Transform player;

    //when an object touches or overlaps with this object
    private void OnCollisionEnter(Collision collisionInfo)
    {
        Debug.Log("Teleporter Entered");

        if (collisionInfo.collider.tag == "Player")
        {
            Debug.Log("Teleporter Entered"); 
            player.position = destination;
        }
    }
}
