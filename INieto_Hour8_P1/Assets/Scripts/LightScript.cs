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
        //lightComponent.type = LightType.Directional;
    }

    // Update is called once per frame
    void Update()
    {
        L_Pressed = Input.GetKeyDown(KeyCode.L);
        if (L_Pressed)
        {
            Debug.Log("L pressed! Light off...");
            //LightObj = GetCompo
            lightComponent.intensity = Mathf.PingPong(Time.time, 0);

        }
        //else
        //    lightComponent.intensity = 

    }
}
