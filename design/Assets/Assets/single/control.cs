using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace Single {
public class control : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
           Debug.Log(single.instance.name);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
}