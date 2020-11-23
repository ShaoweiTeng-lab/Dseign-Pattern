using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Builder { 
public class control : MonoBehaviour
{
        void Start()
        {
            UnitTest();
        }

        void UnitTest()
        {
            // 建立
            Director theDirectoir = new Director();
            Product theProduct = null;

            // 使用BuilderA建立
            theDirectoir.Construct(new ConcreteBuilderA());
            theProduct = theDirectoir.GetResult();
            theProduct.ShowProduct();

            // 使用BuilderB建立
            theDirectoir.Construct(new ConcreteBuilderB());
            theProduct = theDirectoir.GetResult();
            theProduct.ShowProduct();
        }
    }
}
