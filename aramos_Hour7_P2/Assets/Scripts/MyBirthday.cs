using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyBirthday : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int october = 1;
        for (int count = 1; count <= 31; count++)
        {
            october = count;

        if (october == 21)
            {
                Debug.Log("Its my birthday!");
            }
        else
            {
                Debug.Log(october);
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
