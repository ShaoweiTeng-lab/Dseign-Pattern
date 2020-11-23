using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface   Componenet {
     int damage { get; set; }
     void SendMessage();
}

public class Player : Componenet
{
    public int damage { get; set; }
    public Player(int damage) {
        this.damage = damage;
    }
    public void SendMessage()
    {
        Debug.Log("玩家顯示裝備  damage  : "+ damage);
    }
}
public class Decorator_ : Componenet//繼承
{
    Componenet Componenet_;
    public int damage { get; set; }
    public Decorator_(Componenet Componenet_) {

        this.Componenet_ = Componenet_;
        damage = Componenet_.damage;

    }
    public  void SendMessage()
    {
        Componenet_.SendMessage();
    }
}

public class Wepon1 : Decorator_ {
    Componenet Componenet_;
    public Wepon1(Componenet Componenet_) : base(  Componenet_) {

        this.Componenet_ = Componenet_;
    }

    public  void SendMessage()
    {
        base.SendMessage();
        Componenet_.damage += 10;
        Debug.Log("玩家 獲得 Wepon1   10  damage : " + Componenet_.damage);
    }


}

public class Wepon2 : Decorator_
{
    Componenet Componenet_;
    public Wepon2(Componenet Componenet_) : base(Componenet_)
    {
        this.Componenet_ = Componenet_;

    }

    public   void SendMessage()
    {
        base.SendMessage();
        Componenet_.damage +=20;
        Debug.Log("玩家 獲得 Wepon2  20  damage : " + Componenet_.damage);
    }


}
