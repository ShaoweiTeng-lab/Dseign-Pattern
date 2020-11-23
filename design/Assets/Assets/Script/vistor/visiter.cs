using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//https://www.1ju.org/design-pattern/visitor-pattern
public interface IVisiter 
{   //多載
    void VisitPerson(Man Man_);
    void VisitPerson(Women Women_);
}
class Visiter_ : IVisiter
{
    public void VisitPerson(Man Man_)
    {
        Debug.Log("Men 被訪問");
    }

    public void VisitPerson(Women Women_)
    {
        Debug.Log("Women 被訪問");
    }
}
public interface Person {
    void Accept(IVisiter theVisitor);
    
}

public class Man : Person
{
    public void Accept(IVisiter theVisitor)
    {   
        theVisitor.VisitPerson(this);
        MenAttack();
    }
    void MenAttack()
    {//class自己內部方法

        Debug.Log("男生攻擊中");
    }
}
public class Women : Person
{
    public void Accept(IVisiter theVisitor)
    {
        theVisitor.VisitPerson(this);
        WomenAttack();
    }
    void WomenAttack()//class自己內部方法
    {

        Debug.Log("女生攻擊中");
    }
}

// 用來存儲所有的Person	
public class ObjectStructure
{
    List<Person> m_Person = new List<Person>();


    public void AddPerson(Person Person_) {

        m_Person.Add(Person_);
    }

    // 載入不同的Action(Visitor)來判斷
    public void RunVisitor(IVisiter theVisitor)
    {
        foreach (Person thePerson in m_Person)
            thePerson.Accept(theVisitor);
    }
}
