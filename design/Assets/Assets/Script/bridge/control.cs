using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
namespace bridge
{
    public class control : MonoBehaviour 
    {
        // 新增兩個圓形物件，分別指定不同畫圖物件
        Circle a = new Circle(new DrawCircle_A());
        

        // 分別畫出圓形
    
      

        // Update is called once per frame
        void Update()
        {
            if (Input.GetKeyDown(KeyCode.R))
            {   
                 
                a = new Circle(new DrawCircle_B());
                GC.Collect();
                
            }
            if (Input.GetKeyDown(KeyCode.Mouse0))
            {
                a.Draw();
            }
        }
    }
}
