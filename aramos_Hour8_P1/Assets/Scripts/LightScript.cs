using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightScript : MonoBehaviour
{
    Light myLight;
    // Start is called before the first frame update
    void Start()
    {
        myLight = GetComponent<Light>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.L))
            myLight.intensity = Mathf.PingPong(5, 1);
        else
            myLight.intensity = Mathf.PingPong(0, 5);
    }
}
