using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Abstract_Factory {
public class Control : MonoBehaviour
{
    AbstractFactory Factory;
    // Start is called before the first frame update
    void Start()
    {   // 工廠1
		Factory = new ConcreateFactory1();
		// 產生兩個產品
		Factory.CreateProductA();
		Factory.CreateProductB();

		// 工廠2
		Factory = new ConcreateFactory2();
		// 產生兩個產品
		Factory.CreateProductA();
		Factory.CreateProductB();
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
}
