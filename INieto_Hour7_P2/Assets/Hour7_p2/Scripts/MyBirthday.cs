using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyBirthday : MonoBehaviour
{
    int days;
    // Start is called before the first frame update
    void Start()
    {
        for(days = 1; days <= 31; days++)
        {
            if (days == 28)
                Debug.Log("Its my birthday!");
            else
                Debug.Log(days);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
