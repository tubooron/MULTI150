using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DmgScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // TIY 1 Creating a method that accepts an int parameter and returns an int
    int TakeDamage(int damageAmount)
    {
        int health = 100;
        return health - damageAmount;

    }
}
