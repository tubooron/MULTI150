using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BounceCounter : MonoBehaviour
{
    // Creating variable that will hold the bounce counter
    int bounceCtr = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // OnTriggerEnter method alone with the print is enough to work properly
    void OnTriggerEnter(Collider other)
    {
        bounceCtr++;
        //print("Bounce Counter: " + bounceCtr);
    }

    // OnTriggerExit below prints the amount of times it has bounced
    void OnTriggerExit(Collider other)
    {
        print("Bounce Counter: " + bounceCtr);
    }
}
