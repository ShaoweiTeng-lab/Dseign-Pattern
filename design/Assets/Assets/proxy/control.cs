using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class control : MonoBehaviour
{
    Proxy Proxy_ = new Proxy();
    void Start()
    {
        Proxy_.Accept = true;
        Proxy_.Request();
        //Proxy_.Accept = false;
        //Proxy_.Request();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
