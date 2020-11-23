using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public interface action {

    void sendmessage(string message);
}
// 中介者
public class Mediator
{
    public medic medic_;
    public actor actor_;
    action _action;
    public void getandsendmessage(InfantryColleagueall InfantryColleagueall_, string message) {
        switch (InfantryColleagueall_)
        {
            case InfantryColleagueall.hurt:
                medic_.sendmessage( message);
                break;
            case InfantryColleagueall.attack:
                actor_.sendmessage(message);
                break;
            case InfantryColleagueall.normal:
                Debug.Log(message);
                break;
        }

    }

}

public class medic : Mediator, action
{   
    public medic(Mediator _Mediator)
    {
        _Mediator.medic_ = this;
        
    }


    public void sendmessage( string message)
    {
        Debug.Log(string.Format("{0}，醫療兵即前往", message));
    }
}

public class actor: Mediator, action
{

    public actor(Mediator _Mediator)
    {
        _Mediator.actor_ = this;

    }

    public void sendmessage( string message)
    {
        Debug.Log(string.Format("{0}，士兵即前往，準備攻擊", message));
    }
}





public enum InfantryColleagueall//事件類型
{

    hurt, attack, normal
}
