using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    float health = 1004, poisonDamage = 125.5f;
    // Start is called before the first frame update
    void Start()
    {
        // Code below is from P1

        //Debug.Log(health);
        //health -= poisonDamage;
        //Debug.Log(health);
        //health -= poisonDamage;
        //Debug.Log(health);
        //health -= poisonDamage;
        //Debug.Log(health);
        //health -= poisonDamage;
        //Debug.Log(health);
        //health -= poisonDamage;
        //Debug.Log(health);
        //health -= poisonDamage;
        //Debug.Log(health);
        //health -= poisonDamage;
        //Debug.Log(health);
        //health -= poisonDamage;
        //Debug.Log(health);
        //health -= poisonDamage;
        //Debug.Log("BEFORE WHILE ^^^");


        // Part 2 of Hour 7 loop to reduce the health until it reaches 0

        while (health>0)
        {
            health -= poisonDamage;
            Debug.Log(health);

            
        }

        if (health <= 0)
            Debug.Log("Player has been unalived!");

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
