using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LampAnimationControl : MonoBehaviour
{
    // Initializes Animator object we are going to be using to get a reference by in later code
    Animator anim;
    
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {

        // Plays the Color Change Animation when W is pressed
        if(Input.GetKeyDown(KeyCode.W))
            anim.SetTrigger("ColorChange");

        // Plays the Scale Animation when A is Pressed
        if(Input.GetKeyDown(KeyCode.A))
            anim.SetTrigger("ScaleChange");

        // Plays the Spinning Animation when S is pressed
        if (Input.GetKeyDown(KeyCode.S))
            anim.SetTrigger("RotateChange");

        // Plays the Hover Animation when D is pressed
        if (Input.GetKeyDown(KeyCode.D))
            anim.SetTrigger("HoverChange");
    }
}
