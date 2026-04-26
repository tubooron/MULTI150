using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoalScript : MonoBehaviour
{
    public bool isSolved = false;
    // Variable to keep count of Chaos Balls
    private int chaosBallCounter = 5;
    //GameObject gameObject;
    
    // Start is called before the first frame update
    void Start()
    {
        //for(i = 0; chaosBallCounter == ; i++)
        GameObject[] chaosBalls = GameObject.FindGameObjectsWithTag("Chaos");
        chaosBallCounter = chaosBalls.Length;
        print(chaosBallCounter);
        

        //if(GameObject.FindGameObjectsWithTag("Chaos"))
        //{
        //    chaosBallCounter++;
        //}
        //print(chaosBallCounter);
        //for(i = 0; ;i++)
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    void OnTriggerEnter(Collider collider)
    {
        GameObject collidedWith = collider.gameObject;
        if (collidedWith.tag == gameObject.tag)
        {
            isSolved = true;
            GetComponent<Light>().enabled = false;
            Destroy(collidedWith);
        }
    }
}
