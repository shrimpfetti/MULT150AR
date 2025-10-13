using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Evens : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int evens = 22;
        for (int count = 22; count <= 100; count += 2)
        {
            if (count <= 100)
            {
                evens = count;
                Debug.Log(evens);
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
