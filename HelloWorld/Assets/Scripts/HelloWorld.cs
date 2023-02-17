using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HelloWorld : MonoBehaviour
{

    int m_frame = 0;

    void Start()
    {
        Debug.Log("Hello World");    
    }

    void Update()
    {
        m_frame++;
    }
}
