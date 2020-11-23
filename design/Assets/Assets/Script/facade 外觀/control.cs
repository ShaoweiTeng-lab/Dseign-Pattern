using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace Facade
{
    public class control : MonoBehaviour
    {


        public Material _materal;
        [SerializeField]
        facade facade;
        // Start is called before the first frame update

        private void Awake()
        {   //初始物件
            facade = new facade(this, _materal);
           
        }

        // Update is called once per frame
        void Update()
        {
            if (Input.GetKey(KeyCode.X))
            {
                facade.dothing();

            }

        }
    }
}