using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// 可生成各抽象成品物件的操作 抽象工廠
public abstract class AbstractFactory
{
    public abstract AbstractProductA CreateProductA();
    public abstract AbstractProductB CreateProductB();
}
//產生  ProjectA1 及  ProjectB1 的工廠
public class ConcreateFactory1 : AbstractFactory
{
    

    public override AbstractProductA CreateProductA()
    {
        return new ProductA1();
    }
    public override AbstractProductB CreateProductB()
    {
        return new ProductB1();
    }
}

//產生 ProjectA2 及  ProjectB2 的工廠
public class ConcreateFactory2 : AbstractFactory
{


    public override AbstractProductA CreateProductA()
    {
        return new ProductA2();
    }
    public override AbstractProductB CreateProductB()
    {
        return new ProductB2();
    }
}

// 成品A界面
public abstract class  AbstractProductA {
}

// 成品物件類型A1
public class ProductA1 : AbstractProductA
{
    public ProductA1()
    {
        Debug.Log("生成 Product A1");
    }
}
// 成品物件類型A2
public class ProductA2 : AbstractProductA
{
    public ProductA2()
    {
        Debug.Log("生成  Product  A2 ");
    }
}
// 成品物件類型B界面
public abstract class AbstractProductB {

}

// 成品物件類型B1
public class ProductB1 : AbstractProductB
{
    public ProductB1()
    {
        Debug.Log("生成 Product  B1");
    }
}
// 成品物件類型B1
public class ProductB2 : AbstractProductB
{
    public ProductB2()
    {
        Debug.Log("生成 Product  B2");
    }
}

