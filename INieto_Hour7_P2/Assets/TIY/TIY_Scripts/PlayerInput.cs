using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInput : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        // Code below is from a TIY to check the axis (Is commented out when modifying for the Key presses TIY)
        //float hVal = Input.GetAxis("Horizontal");
        //float vVal = Input.GetAxis("Vertical");

        //if (hVal != 0)
        //    print("Horizontal movement selected: " + hVal);
        //if (vVal != 0)
        //    print("Vertical movement selected: " + vVal);

        // Code below is from a TIY to check when a key is being pressed, receiving input, or being held down (Commented out for Reading Mouse Movement TIY)
        //if (Input.GetKey(KeyCode.M))
        //    print("The 'M' key is pressed down");
        //if (Input.GetKeyDown(KeyCode.O))
        //    print("The 'O' key was pressed");

        //Code below is from a TIY (Reading Mouse Movement)
        float mxVal = Input.GetAxis("Mouse X");
        float myVal = Input.GetAxis("Mouse Y");
        if (mxVal != 0)
            print("Mouse X movement selected: " + mxVal);
        if (myVal != 0)
            print("Mouse Y movement selected: " + myVal);
    }
}
