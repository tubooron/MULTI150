using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrefabGenerator : MonoBehaviour
{
    public GameObject prefab;
    float x_Location = -25;
    // Start is called before the first frame update
    void Start()
    {
        for(int i = 0; i < 10; i++)
        {
            Instantiate(prefab, new Vector3(x_Location,0f,-5f), transform.rotation);
            x_Location += 5;
        }
    }

    // Update is called once per frame
    void Update()
    {
        // Whenever we hit the B key we will generate a prefab at the
        // position of the original prefab
        // Whenever we hit the space key, we will generate a prefab at the
        // position of the spawn object that this script is attached to
        if (Input.GetKeyDown(KeyCode.B))
            Instantiate(prefab);
        if (Input.GetKeyDown(KeyCode.Space))
            Instantiate(prefab, transform.position, transform.rotation);
    }
}
