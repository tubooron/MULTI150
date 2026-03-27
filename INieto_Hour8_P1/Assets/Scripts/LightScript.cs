using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightScript : MonoBehaviour
{
    public GameObject LightObj;
    private Light lightComponent;
    bool L_Pressed;
    // Start is called before the first frame update
    void Start()
    {
        lightComponent = GetComponent<Light>();
    }

    // Update is called once per frame
    void Update()
    {
        // Code below tests to see if the key was pressed
        L_Pressed = Input.GetKeyDown(KeyCode.L);

        // If L is pressed AND the light component is currentltly on, it will turn off the light
        // Although, if L is pressesd and the light is off it will turn the light on
        if (L_Pressed && lightComponent.enabled == true)
            lightComponent.enabled = false;
        else if (L_Pressed && lightComponent.enabled == false)
            lightComponent.enabled = true;
    }
}
