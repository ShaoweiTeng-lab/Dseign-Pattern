using System.Collections;
using System.Collections.Generic;
using UnityEngine;


// 應用域領(Client)所需的介面


public interface Target
{
    void Request();
}

// 不同於應用域領(Client)的實作,需要被轉換
public class Adaptee
{
    public Adaptee() { }

    public void SpecificRequest()
    {
        Debug.Log("呼叫Adaptee.SpecificRequest");
    }
}

// 將Adaptee轉換成Target介面
public class Adapter_ : Target
{
    private Adaptee m_Adaptee = new Adaptee();


    public void Request()
    {
        m_Adaptee.SpecificRequest();
    }
}

#region 寵物系統應用

public interface Imonster
{
    int Level { get; set; }
    string Name { get; }


}


public class Monster : Imonster
{
    public int Level { get; set; }
    public string Name { get; }
    public Monster(string Name, int Level) {
        this.Level = Level;
        this.Name = Name;

    }
    public void SendDamage() {

        Debug.Log(string.Format("名稱:  {0}  ， 等級 {1}", Name,Level));
    }
}

public class Pat : Imonster {
    public int Level { get; set; }

    public string Name { get; set; }  

    Imonster Imonster_;
    public Pat(Imonster Imonster_) {
        this.Imonster_ = Imonster_;
        Imonster_.Level = 1;
    }
    public void SendMessage() {

        Debug.Log(string.Format("已收服 {0}  ， 寵物等級 {1}", Imonster_.Name, Imonster_.Level));
    }

    public void Addlevel(int Level) {

        Imonster_.Level += Level;
        Debug.Log("提升 " + Level + "等");
    }

}
#endregion

