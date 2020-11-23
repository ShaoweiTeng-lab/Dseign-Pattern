using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Memento { 
public class control : MonoBehaviour
{
        // Use this for initialization
        void Start()
        {
            UnitTest();	
            //UnitTest2();
        }

        // 
        void UnitTest()
        {

            Originator theOriginator = new Originator();

            // 設定資訊
            theOriginator.SetInfo("Step1");
            theOriginator.ShowInfo();

            // 儲存狀態
            memento theMemnto = theOriginator.CreateMemento();//此時   theOriginator m_state =Step1 ,並將值傳給theMemnto

            // 設定新的資訊
            theOriginator.SetInfo("Step2");
            theOriginator.ShowInfo();//更改新的值 theOriginator m_state 變成  "Step2, theMemnto 不變

            // 復原
            theOriginator.SetMemento(theMemnto);
            theOriginator.ShowInfo();//顯示上一版本的 m_state

        }

        // 
        void UnitTest2()
        {

            Originator theOriginator = new Originator();
            Caretaker theCaretaker = new Caretaker();

            // 設定資訊
            theOriginator.SetInfo("Version1");
            theOriginator.ShowInfo();
            // 保存
            theCaretaker.AddMemento("1", theOriginator.CreateMemento()); //theOriginator.CreateMemento()  = new  Memento(m_state)

            // 設定資訊
            theOriginator.SetInfo("Version2");
            theOriginator.ShowInfo();
            // 保存
            theCaretaker.AddMemento("2", theOriginator.CreateMemento());

            // 設定資訊
            theOriginator.SetInfo("Version3");
            theOriginator.ShowInfo();
            // 保存
            theCaretaker.AddMemento("3", theOriginator.CreateMemento());

            // 退回到第2版,
            theOriginator.SetMemento(theCaretaker.GetMemento("2"));//dictionary getkey 後傳給theOriginator 
            theOriginator.ShowInfo();

            // 退回到第1版,
            theOriginator.SetMemento(theCaretaker.GetMemento("1"));
            theOriginator.ShowInfo();



        }
    }
}
