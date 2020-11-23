using System.Collections;
using System.Collections.Generic;
using UnityEngine;



// 主題介面
public interface ISubject
{
    List<IObserver> Observers { get; set; }
    void Attach(IObserver observer);
    void Detach(IObserver observer);
    void Notify(string message,int playerhealth);
}
// 主題實作
public class SubjectEflow : ISubject
{
    public List<IObserver> Observers { get; set; }

    public SubjectEflow() {

        Observers = new List<IObserver>();
    }
    
    public void Detach(IObserver observer)
    {
      
           Observers.Remove(observer);
    }
    public void Notify(string message,int playerhealth)
    {
        foreach (IObserver observer in this.Observers)
        {
            observer.Update(message,playerhealth);
        }
    }
    public void Attach(IObserver observer)
    {
        
            Observers.Add(observer);
    }
}

// 觀察者介面

public interface IObserver
{
    void Update(string message ,int playerhealth);
}
public class ConcreteObserver1 : IObserver
{
    public void Update(string message, int playerhealth)
    {
        Debug.Log("ConcreteObserver1.Update 已收到  " + message);
        if (playerhealth < 10) {
            Debug.Log("ConcreteObserver1.Update 出動醫療兵 ");

        }
    }
}
public class ConcreteObserver2 : IObserver
{
    public void Update(string message, int playerhealth)
    {
        Debug.Log("ConcreteObserver2.Update 已收到  " + message);

        if (playerhealth > 10)
        {
            Debug.Log("ConcreteObserver2.Update 坦克出動了 ");

        }
    }
}
