using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace responsibility
{
    public class control : MonoBehaviour
    {

        Handler Handler_1 = new ConcreteHandler1();
        Handler Handler_2 = new ConcreteHandler2(); 
        // Start is called before the first frame update
        void Start()
        {
            Handler_1.nexthandlerPut(Handler_2);
            Handler_1.HandleRequest(5);
        }

        // Update is called once per frame
        void Update()
        {

        }
    }
}
 
