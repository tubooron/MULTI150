using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    // Creates public variables to be able  to edit later on as the game plays
    public TextureScroller ground;
    public float gameTime = 10;

    float totalTimeElapsed = 0;
    bool isGameOver = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update keeps track of time and adds the time since the last frame
    void Update()
    {
        if (isGameOver)
            return;

        totalTimeElapsed += Time.deltaTime;
        gameTime -= Time.deltaTime;

        if (gameTime <= 0)
            isGameOver = true;
    }

    public void AdjustTime(float amount)
    {
        gameTime += amount;
        if (amount < 0)
            SlowWorldDown();
    }
    // Method below slows down time when a player hits an obstacle
    void SlowWorldDown()
    {
        // Cancel any invokes to speed the world up
        // Then slow the world down for 1 second
        CancelInvoke();
        Time.timeScale = 0.5f;
        // Invoke below cancels any of the SpeedWorldUp methods waiting to be called since the player hit another obstacle
        Invoke("SpeedWorldUp", 1);
    }
    // Returns the world speed to the default
    void SpeedWorldUp()
    {
        Time.timeScale = 1f;
    }

    // Note this is using Unity's legacy GUI system
    void OnGUI()
    {
        if (!isGameOver)
        {
            Rect boxRect = new Rect(Screen.width / 2 - 50, Screen.height - 100, 100, 50);
            GUI.Box(boxRect, "Time Remaining");

            Rect labelRect = new Rect(Screen.width / 2 - 10, Screen.height - 80, 20, 40);
            GUI.Label(labelRect, ((int)gameTime).ToString());
        }
        else
        {
            Rect boxRect = new Rect(Screen.width / 2 - 60, Screen.height / 2 - 100, 120, 50);
            GUI.Box(boxRect, "Game Over");
            Rect labelRect = new Rect(Screen.width / 2 - 55, Screen.height / 2 - 80, 90, 40);
            GUI.Label(labelRect, "Total Time:" + (int)totalTimeElapsed);

            Time.timeScale = 0;
        }

    }
}
