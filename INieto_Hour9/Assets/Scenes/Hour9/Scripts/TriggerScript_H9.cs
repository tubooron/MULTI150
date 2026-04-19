using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerScript_H9 : MonoBehaviour
{
    public GameObject triggerYouWant;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }



    void OnTriggerEnter(Collider other)
    {
        print(other.gameObject.name + " Entered " + triggerYouWant.name);
    }

    void OnTriggerExit(Collider other)
    {
        print(other.gameObject.name + " Exited " + triggerYouWant.name);
    }

    void OnTriggerStay(Collider other)
    {
        print(other.gameObject.name + " Staying in " + triggerYouWant.name);
    }
}
