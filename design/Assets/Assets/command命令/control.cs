using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Control
{
    public class control : MonoBehaviour
    {
        Invoke Invoke_= new Invoke( );
         
        // Start is called before the first frame update
        void Start()
        {
            Invoke_.addCommands(new Receiver());
            Invoke_.addCommands(new Receiver1());
            Invoke_.action();
            
        }
 
    }
}
