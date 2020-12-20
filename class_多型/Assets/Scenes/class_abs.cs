using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class class_abs : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Test();
    }
    void Test()
    {
        #region 父名子體
        A class_A = new B();
        class_A.A_Owndothing();//執行A 無法執行B_Owndothing因為  Class a 中無定義此方法
        class_A.DoThing();//執行 B的內容因為已經被override
        #endregion
        #region 子名父體
        //B classB_A = new A();//子名父體 跳錯
        #endregion
        //B classB_A = new A() as B;



        //classB_A.DoThing();////子轉父後找不到 執行跳錯






    }

}




class A
{


    public void A_Owndothing()
    {//A專屬的方法

        Debug.Log("A_Owndothing");
    }
    public virtual void DoThing()
    {

        Debug.Log("A_DoThing");
    }


}

class B : A
{

    public override void DoThing()
    {

        Debug.Log("B_DoThing");
    }
    public void B_Owndothing()
    {//B專屬的方法

        Debug.Log("A_Owndothing");
    }

}


abstract class absClassA
{


}

class DoClassA : absClassA
{



}
