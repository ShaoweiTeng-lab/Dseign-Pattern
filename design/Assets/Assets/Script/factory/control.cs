using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Factory {

    public class control : MonoBehaviour
    {
        product _product;
        factory productfactory=new factory();
        // Start is called before the first frame update
        void Start()
        {
            _product = productfactory.createproduct(0);//回傳一個product

        }

        // Update is called once per frame
        void Update()
        {
            if (Input.GetKeyDown(KeyCode.Mouse0)) {

                _product = productfactory.createproduct(0);
            }
            if (Input.GetKeyDown(KeyCode.Mouse1))
            {

                _product = productfactory.createproduct(1);
            }
            if (Input.GetKeyDown(KeyCode.A))
            {

                _product.dothing();
            }
        }
    }

}

