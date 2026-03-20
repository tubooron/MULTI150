using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Evens : MonoBehaviour
{
    int counter;
    // Start is called before the first frame update
    void Start()
    {
        for (counter = 22; counter <= 100; counter++)
        {
            if (counter % 2 == 0)
                Debug.Log(counter);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
