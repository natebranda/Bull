using UnityEngine;
using System.Collections.Generic;

/// <summary>
/// This script creates and manages the To Do list for Angus's daily chores.
/// It connects to the chore objects to ensure that time progresses as it 
/// should and chores that are completed are marked as such.
/// 
/// The 7 chores are:
///     Daily Routine
///     Meal
///     Telephone
///     TV
///     Piano
///     Lawn Chair
///     Bed
/// 
/// </summary>
public class ToDoList : MonoBehaviour
{
    //The current time in hours, where 0 -> 12PM, 1 -> 1PM, 6 -> 6PM, etc.
    public int timeCounter;

    //The list of all chores that can be completed on the current day
    public List<string> remainingChores;

    //The chores that must be complete before the day can end
    public List<string> remainingEssentialChores;

    private GameManager gameManager;

    //The number of meals that must be eaten before the day is completed
    private int mealsLeft;

    //Used for initialization
    private void Awake()
    {
        timeCounter = 0;
        gameManager = GetComponent<GameManager>();
        mealsLeft = 2;
    }

    /// <summary>
    /// Public method that removes the name of a completed chore from the 
    /// remainingChores list and then uses the UpdateToDoList method.
    /// </summary>
    /// <param name="choreName">The completed chore's name as a string</param>
    public void MarkChoreComplete(string choreName)
    {
        remainingChores.Remove(choreName);

        if (remainingEssentialChores.Contains(choreName))
        {
            remainingEssentialChores.Remove(choreName);
        }

        UpdateToDoList(choreName);
    }

    /// <summary>
    /// Increases the timeCounter by the given number of hours.
    /// </summary>
    /// <param name="hours">The number of hours that have passed</param>
    public void PassTime(int hours)
    {
        timeCounter += hours;
    }

    /// <summary>
    /// Updates the contents of the remainingChores list based on the current time and
    /// the chore that was just completed.
    /// </summary>
    private void UpdateToDoList(string completedChore)
    {
        //when Meal is completed for the first time
        if (completedChore == "Meal" && mealsLeft == 2)
        {
            //Lunch is completed
            List<string> newChores = new List<string> 
                {"Telephone", "TV", "Piano", "LawnChair"};
            remainingChores.AddRange(newChores);
            mealsLeft--;
        }

        if (timeCounter >= 5 && mealsLeft == 1)
        {
            remainingChores.Add("Meal");
            mealsLeft--;
        }
        
        if (remainingEssentialChores.Count == 0 
            && !remainingChores.Contains("Bed")
            && timeCounter >= 6)
        {
            remainingChores.Add("Bed");
        }
        
        if (completedChore == "Bed")
        {
            gameManager.EndDay();
        }

    }
}
