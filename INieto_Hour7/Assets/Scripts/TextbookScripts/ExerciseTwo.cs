using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Code below is a script that outputs all the numbers from 1-100 except for the multiples of 3 or 5
// (Numbers that are divisible by 3 or 5 and their result is 3/5) or (The product of a number is reached with 3 or 5)
public class ExerciseTwo : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
        for (int count = 0; count <= 100; count++)
        {
            if(count % 3 == 0 || count % 5 == 0)
            {
                // Code below will print IF the numbers are multiples of 3||5
                print("Programming is awesome!");
            }
           
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
