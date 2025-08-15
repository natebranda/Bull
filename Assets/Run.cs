using UnityEngine;

/// <summary>
/// Currently a script for testing
/// </summary>
public class Run : MonoBehaviour
{
    public Rigidbody rb;
    public Vector3 speed;

    // Start is called once when the scene initializes
    void Start()
    {
        rb.AddForce(speed, ForceMode.VelocityChange);
    }
}
