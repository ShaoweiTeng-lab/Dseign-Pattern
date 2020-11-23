using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Visiter
{
    public class control : MonoBehaviour
    {
        ObjectStructure theStructure = new ObjectStructure();
        Man Man_ = new Man();
        Women Women_ = new Women();
        // 將Vicitor走訪ObjectStructure裡的各元表

        // Start is called before the first frame update
        void Start()
        {
            theStructure.AddPerson(Man_);
            theStructure.AddPerson(Women_);
            theStructure.RunVisitor(new Visiter_());
           
        }

        // Update is called once per frame
        void Update()
        {

        }
    }
}
