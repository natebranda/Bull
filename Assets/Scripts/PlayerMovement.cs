using UnityEngine;

/// <summary>
/// Carries out player movement and rotation from user inputs.
/// </summary>
public class PlayerMovement : MonoBehaviour
{
    /// <summary>
    /// The distance travelled each time the player moves.
    /// </summary>
    public static int step = 1;

    /// <summary>
    /// The angular displacement caused each time the player turns right.
    /// </summary>
    Quaternion turnRight = Quaternion.Euler(0, 90, 0);

    /// <summary>
    /// The angular displacement caused each time the player turns right.
    /// </summary>
    Quaternion turnLeft = Quaternion.Euler(0, -90, 0);

    /// <summary>
    /// The distance left to be traveled via using Translate on the player.
    /// Starts at the distance value of step so we do not step forward immediately.
    /// </summary>
    private float distanceTraveled = step;

    /// <summary>
    /// Update is called once per frame, here it checks for relevant
    /// player input.
    /// </summary>
    void Update()
    {
        //if a step was initiated but has not yet completed
        if (distanceTraveled < step)
        {
            //Complete step (over several frames using Translate)
            translate();
            //prevent further input until
            return;
        }
                
        //check if player has pressed left, right, or forward
        if (Input.GetKeyDown("w"))
        {
            //sets distance traveled back to zero to make the
            //translate block below run
            distanceTraveled = 0;
        }
        else if (Input.GetKeyDown("d"))
        {
            //rotates exactly 90 degrees to the right instantly
            transform.rotation *= turnRight;
        }
        else if (Input.GetKeyDown("a"))
        {
            //rotates exactly 90 degrees to the left instantly
            transform.rotation *= turnLeft;
        }
    }

    /// <summary>
    /// Moves the player forward a distance of one step and then stops
    /// the player immediately at that position.
    /// </summary>
    private void translate()
    {
        Vector3 lastPosition = transform.position;
        //Move object forward this frame
        transform.Translate(0, 0, 5 * Time.deltaTime);
        //update distance traveled to be accurate
        distanceTraveled += Vector3.Distance(lastPosition, transform.position);
    }

}
