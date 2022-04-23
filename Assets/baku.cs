using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class baku : MonoBehaviour
{
    float time;
    // Start is called before the first frame update
    void Start()
    {
        Console.WriteLine("おは");
    }

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;
        if (Time.deltaTime>1)
        {
            Destroy(this);
        }
    }
}
