using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControl : MonoBehaviour
{
    public float mxAxis, myAxis;
    public GameObject Camera;
    
    // Start is called before the first frame update
    void Start()
    {
        //transform.Translate();
    }

    // Update is called once per frame
    void Update()
    {
        // Code below on every frame gets the X & Y mouse input and applies it to the camera's transform

        mxAxis = Input.GetAxis("Mouse X");
        myAxis = Input.GetAxis("Mouse Y");
        Camera.transform.Translate(mxAxis,myAxis,0f);

    }
}
