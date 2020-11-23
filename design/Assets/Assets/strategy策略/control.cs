using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Strategy
{
    public class control : MonoBehaviour
        
    {   context context_ = new context(new state0());
        
       
        // Start is called before the first frame update
        void Start()
        {
           
        }

        // Update is called once per frame
        void Update()
        {
            if (Input.GetKeyDown(KeyCode.Mouse0)) {

                context_.attack();
            }
            if (Input.GetKey(KeyCode.Mouse1)) {

                context_ = new context(new state1());
            }
        }
        void Function()
        {
            print("hi");

        }
        void Function2()
        {
            print("hi2");

        }
    }
   
}

 


 