using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoalScript : MonoBehaviour
{
    public bool isSolved = false;
    // Variable to keep count of Chaos Balls
    // Since the goal also has the same "Chaos" tag I set the counter to 1
    private int chaosBallCounter = 1;
    private int chaosArrLength;

    // Start is called before the first frame update
    void Start()
    {
        GameObject[] chaosBalls = GameObject.FindGameObjectsWithTag("Chaos");
        chaosArrLength = chaosBalls.Length;
        print(chaosArrLength);
    }
        // Gameobject Array to find all objects with the "Chaos" tag to be able to know how many are placed in the world and to count for later
        //private GameObject[] chaosBalls = GameObject.FindGameObjectsWithTag("Chaos");
        
    

    // Update is called once per frame
    void Update()
    {
        
    }
    
    void OnTriggerEnter(Collider collider)
    {
        GameObject collidedWith = collider.gameObject;
        
        /*Code below is modified from the prototype
         * It will now also check if Chaos balls are being collided with (comparing tag) and will set isSolved to true
         * AND if the all the chaos balls were collected it will then execute the code nested inside the if statement
         */
        if (collidedWith.tag == gameObject.tag)
        {
            if (collidedWith.CompareTag("Chaos"))
            {
                chaosBallCounter++;
                Destroy(collidedWith);
                print("CHAOS COUNTER: " + chaosBallCounter);

                if (chaosBallCounter == chaosArrLength)
                {
                    isSolved = true;
                    GetComponent<Light>().enabled = false;
                }
            }
            else
            {
                isSolved = true;
                GetComponent<Light>().enabled = false;
                Destroy(collidedWith);
            }
            
        }  
    }
}
