using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestEvents : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        print("This will only be printed once");
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("this will be printed lots of times");
    }
}
