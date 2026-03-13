using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Code bwlow will add together all the even numbers from 2 to 499
public class ExerciseOne : MonoBehaviour
{
    // Creating variables to hold values
    public int sum = 0;
    // Start is called before the first frame update
    void Start()
    {
        
        // Begins the loop to add the even numbers
        for (int count = 0; count < 499; count++)
        {
            // Makes sure numbers are even by checking if they are able to be divided by 2 and have no remainder.
            // If this is true then it will add it to the sum, else it will do nothing
            if (count % 2 == 0)
            {
                sum += count;
            }
          print("Count: " + count);
          print("Sum: " + sum);
        }
        
        
        print("Overall Sum: " + sum);
       
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
