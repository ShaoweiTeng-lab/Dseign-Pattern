using System.Collections;
using System.Collections.Generic;
using UnityEngine;

 

    public abstract class product {

    public abstract void dothing();
    }

    public class product0 : product {

        public override void dothing() {

            Debug.Log("product0_dothing");
        }
    }
    public class product1 : product
    {

    public override void dothing()
        {

            Debug.Log("product1 _dothing");
        }
    }

    public class factory
    { //產生物件工廠
    public product createproduct(int index) {//使用者根據輸入參數回傳值
            switch (index) {
                case 0:
                    return new product0();
                        break;
                case 1:
                    return new product1();
                        break;
                default:
                    return null;

            }
    
        }

    }



 
