using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    float health = 1004, poisonDamage = 125.5f; 
    // Start is called before the first frame update
    void Start()
    {
        // Challenging myself with a while condition that decreases player health with poisonDamage while reducing redundant code and with the same output
       // while(health > 0)
       // {
       //     health -= poisonDamage;
       //     if(health <= 0)
       //     {
       //         Debug.Log("Player Eliminated!");
       //     }
       // }

        // Ignore "while" operation above

        Debug.Log(health);
        health -= poisonDamage;
        Debug.Log(health);
        health -= poisonDamage;
        Debug.Log(health);
        health -= poisonDamage;
        Debug.Log(health);
        health -= poisonDamage;
        Debug.Log(health);
        health -= poisonDamage;
        Debug.Log(health);
        health -= poisonDamage;
        Debug.Log(health);
        health -= poisonDamage;
        Debug.Log(health);
        health -= poisonDamage;
        Debug.Log(health);

        Debug.Log("Player has been unalived!");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
