using System.Collections;
using System.Collections.Generic;
using UnityEngine;



//與decorator 裝飾模式差別在於  decorator   只能直接新增 無法進行判斷要不要新增 因為 物件彼此間不認識
// 制訂RealSubject和Proxy所共用遵偱的介面
public interface Subject
{
     void Request();
      
}

// 定義Proxy所代表的真正物件
public class RealSubject : Subject
{
     

    public  void Request()
    {
         
        Debug.Log("RealSubject 已執行");
    }
}
public class RealSubject2 : Subject
{
    

    public void Request()
    {
       
        Debug.Log("RealSubject2 已執行");
    }
}
//代理專用class
public class Proxy : Subject
{
    RealSubject m_RealSubject = new RealSubject();
    RealSubject2 m_RealSubject2 = new RealSubject2();
     
    // 權限控制
    public bool Accept { get; set; }

    public Proxy()
    {
        Accept = false;
    }

    public  void Request()
    {
        // 依目前狀態決定是否存取RealSubject
        if (Accept) {
            Debug.Log("Proxy已授權");
            m_RealSubject.Request();
            m_RealSubject2.Request();

        }
           
        else
            Debug.Log("Proxy尚未授權執行");
    }
}
