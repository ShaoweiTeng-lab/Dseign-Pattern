using System.Collections;
using System.Collections.Generic;
using UnityEngine;

#region 橋接模式簡介
//為了解決一個介面已經被多個類別給實作，這時候如果我們需要再為此介面新增方法的時候，
//就會面臨到多支類別都要擴充此方法，就會造成擴充不易，甚至有些可能不需要此方法，這時候就可以多加一個新的介面，然後把原本的介面當成屬性
//加在新的介面裡面，然後直接呼叫新介面就也會有擁有原本想擴充介面的屬性，也同時擁有新介面的方法或屬性

#endregion
interface Shape
{
    DrawImplementor drawImplementor { get; set; }

    void Draw();
     
}
//畫圖方法
interface DrawImplementor
{
    void DrawCircle();
}
//abstract class Shape
//{
//    protected DrawImplementor drawImplementor;

//    protected Shape(DrawImplementor drawImplementor)
//    {
//        this.drawImplementor = drawImplementor;
//    }

//    public abstract void Draw();
//}



// 畫圖形的實作介面

// 第1種畫圓形的類別 (實作物件))
class DrawCircle_A : DrawImplementor
{
    public void DrawCircle()
    {
        Debug.Log("DrawCircle_A畫圓形方法");
    }
}

// 第2種畫圓形的類別 (實作物件))
class DrawCircle_B : DrawImplementor
{
    public void DrawCircle()
    {
        Debug.Log("DrawCircle_B畫圓形方法");
    }
}
// "圓形"類別 (抽象物件)
class Circle : Shape
{
    public DrawImplementor drawImplementor
    {
        get;
        set;
    }

    public Circle(DrawImplementor drawImplementor)
    {
        this.drawImplementor = drawImplementor;
    }
    public void Draw()
    {
        drawImplementor.DrawCircle(); // 讓實作物件畫圖形
    }
}