using System.Collections;
using System.Collections.Generic;
using UnityEngine;


//享元模式:共享指的是使用管理結構来設計信息的存储方式，让可以被共享的信息，只需要产生一份对象，而这个对象能够被引用到其他对象中。
//我们把哪些对象只能读取而不能写入的共享部分称为“内在状态”
//把哪些不可共享的如当前生命力，等级，暴击，会随游戏运行而变化的称作外在状态。

//享元模式提供的解决方案是：产生对象时，将能够共享的内在状态加以管理，并且将属于能自由更改的“外部 状态”也一起设置给新产生的对象中。

//不会改变的属性，就设置成为共享组件类，成为属性类的内在状态。

//第一步：确定可以共享的内在状态属性，将其定义成一个类对象
 
public abstract class flyweight 
{
    protected int MaxHP;
    protected float MoveSpeed;
    protected string AttrName;

    public flyweight(int MaxHP, float MoveSpeed  )
    {
        this.MaxHP = MaxHP;
        this.MoveSpeed = MoveSpeed;
         
    }

    public int GetMaxHP()
    {
        return MaxHP;
    }
    public float GetMoveSpeed()
    {
        return MoveSpeed;
    }
  
    
}

// 共用的元件
public class ConcreteFlyweight : flyweight
{
    public ConcreteFlyweight(int MaxHP, float MoveSpeed ) : base(MaxHP,  MoveSpeed)
    {
        
    }

    
}

// 負責產生Flyweight的工廠介面
public class FlyweightFactor
{
    Dictionary<string, flyweight> m_Flyweights = new Dictionary<string, flyweight>();
    
    public flyweight Get_flyweight(string key, int MaxHP, float MoveSpeed) {

        if (m_Flyweights.ContainsKey(key))
        {//假如已經有該KEY 返回相對應的物件
             
            return  m_Flyweights[key];
            
        }

        // 產生並設定內容/沒有該KEY 創造後返回相對應的物件
        else
        {
            ConcreteFlyweight theFlyweight = new ConcreteFlyweight(MaxHP,  MoveSpeed);
            
            m_Flyweights[key] = theFlyweight;
            //Debug.Log("New ConcreteFlyweigh Key[" + key + "]"+(string.Format("MaxHp : {0} , MoveSpeed : {1} ", MaxHP, MoveSpeed )));
            return theFlyweight;
        }
    }
    public flyweight Get_flyweight(string key)//知道key 快速取值 不用在輸入該系數
    {
        if (m_Flyweights.ContainsKey(key))
        {//假如已經有該KEY 返回相對應的物件

            return m_Flyweights[key];

        }
        else {

            return null;
        }

    }

}

