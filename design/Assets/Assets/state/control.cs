using System.Collections;
using System.Collections.Generic;
using UnityEngine;

 
namespace State
{
    public class control : MonoBehaviour
    {
         
        Context a = new Context(new fly());
       
        private void Update()
        {

            if (Input.GetKeyDown(KeyCode.R))
            {

                a.change();

            }
            if (Input.GetKeyDown(KeyCode.E))
            {

                a.sendall();

            }
            if (Input.GetKeyDown(KeyCode.Q))
            {

                a.Q();

            }
        }
        

    }
   
}

