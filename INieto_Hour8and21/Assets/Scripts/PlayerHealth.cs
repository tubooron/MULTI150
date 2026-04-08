using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    // Creating variables
    int healthpoints = 3992;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(healthpoints);
        healthpoints = UsePotion(healthpoints);
        Debug.Log(healthpoints);
        healthpoints = UsePotion(healthpoints);
        Debug.Log(healthpoints);
        healthpoints = UsePotion(healthpoints);
        Debug.Log(healthpoints);
        healthpoints = UsePotion(healthpoints);
        Debug.Log(healthpoints);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // Method below returns an int and increases the player "health"
    public int UsePotion (int health)
    {
        return health += 400;
    }
}
