using UnityEngine;

/// <summary>
/// Contains methods that run when the player collides
/// with another object.
/// </summary>
public class PlayerCollision : MonoBehaviour
{
    public Transform player;

    void OnCollisionEnter(Collision collisionInfo)
    {
        if (collisionInfo.collider.tag == "Obstacle")
        {
            Debug.Log("We hit: " + collisionInfo.collider.name);
        }
    }

}
