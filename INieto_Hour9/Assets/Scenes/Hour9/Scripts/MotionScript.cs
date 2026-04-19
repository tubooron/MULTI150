using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// This script will handle the player being able to move the sphere with the arrow keys
public class MotionScript : MonoBehaviour
{
    // variables will be created that will hold transform float value that will be assigned during movement
    float moveUp = 0.002f, moveLeft = -0.002f, moveDown = -0.002f, moveRight = 0.002f;
    //bool downArrowPressed
    //float keyLeftRight;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        // 1.) Get the arrow keys
        // 2.) If arrow keys are held it will translate in the X/Y 

        // Code below checks if the Up Arrow was pressed and will translate the gameObject Up
        if (Input.GetKey(KeyCode.UpArrow))
        {
            //print("Up Arrow pressed");
            transform.Translate(0f, moveUp, 0f);

        }
        // Code below checks if the Down Arrow was pressed and will translate the gameObject Down
        if (Input.GetKey(KeyCode.DownArrow))
        {
            //print("Down Arrow Pressed");
            transform.Translate(0f, moveDown, 0f);
        }
        // Code below checks if the Left Arrow was pressed and will translate the gameObject Left
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            //print("Left Arrow Pressed");
            transform.Translate(moveLeft, 0f, 0f);
        }
        // Code below checks if the Right Arrow was pressed and will translate the gameObject Right
        if (Input.GetKey(KeyCode.RightArrow))
        {
            //print("Right Arrow Pressed");
            transform.Translate(moveRight, 0, 0);
        }




        

        
        
    }

    //void arrowKeyMovement()
    //{

    //}
}
