using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    /* 
     * Exercise completion is labeled with numbers in the comments if they are within this code
     * Choosen improvements: Add Timer (DONE), Adding variations of the chaos balls, Adding a Chaos goal, Change the shape/size of the players bumper (DONE)
     */
    public GoalScript blue, green, red, orange, chaos;
    private bool isGameOver = true;
    // 1.) Variables is created to keep track of time
    private float elapsedTime = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(!isGameOver)
        {
            elapsedTime += Time.deltaTime;
        }
        // if all four goals are solved then the game is over
        isGameOver = blue.isSolved && green.isSolved && red.isSolved && orange.isSolved;
    }

    /* Create a ChaosBall Method that checks for how many chaos balls there are in the level and saves the number into a variable. 
     * If the Chaos ball is detected it will deduct 1 off the remaing Chaos balls
     * Once there are no chaos balls then the game is completed
     */

    void OnGUI()
    {
        if(isGameOver)
        {
            Rect rect = new Rect(Screen.width / 2 - 100, Screen.height / 2 - 50, 200, 75);
            GUI.Box(rect, "Game Over");
            Rect rect2 = new Rect(Screen.width / 2 - 30, Screen.height / 2 - 25, 60, 50);
            GUI.Label(rect2, "Good Job!");
            // 1.) Added to improve the game. Displays time they completed the game
            GUI.Label(new Rect(Screen.width / 2 - 25, Screen.height / 2 - 2, 60, 50), ("Time: " + ((int)elapsedTime).ToString()));
        }
        // 1.) Added to improve the game. Else was added to display the time the player currently has
        else if(!isGameOver)
        {
            GUI.Box(new Rect(Screen.width / 2 - 65, Screen.height - 115, 130, 40), "Your Time is");
            GUI.Label(new Rect(Screen.width / 2 - 10, Screen.height - 100, 20, 30), ((int)elapsedTime).ToString());
        }

    }
}
