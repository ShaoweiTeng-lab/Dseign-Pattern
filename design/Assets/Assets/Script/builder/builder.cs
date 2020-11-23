using System.Collections;
using System.Collections.Generic;
using UnityEngine;


//適用場景： 

// 1.建立一些複雜的物件時，這些物件的內部組成構件間的建造順序是穩定的，但是物件的內部組成構件面臨著複雜的變化。

//  2.要建立的複雜物件的演算法，獨立於該物件的組成部分，也獨立於組成部分的裝配方法時。
//https://www.itread01.com/content/1548897335.html
//模式角色:
//Proudct(產品類)：一般是一個較為複雜的物件，也就是說建立物件的過程比較複雜，一般會有比較多的程式碼量。在本類圖中，產品類是一個具體的類，而非抽象類。實際程式設計中，產品類可以是由一個抽象類與它的不同實現組成，也可以是由多個抽象類與他們的實現組成。
//Builder(抽象建造者)：引入抽象建造者的目的，是為了將建造的具體過程交與它的子類來實現。這樣更容易擴充套件。一般至少會有兩個抽象方法，一個用來建造產品，一個是用來返回產品。
//ConcreteBuilder(建造者)：實現抽象類的所有未實現的方法，具體來說一般是兩項任務：組建產品；返回組建好的產品。
//Director(導演類)：負責呼叫適當的建造者來組建產品，導演類一般不與產品類發生依賴關係，與導演類直接互動的是建造者類。一般來說，導演類被用來封裝程式中易變的部分。

// 欲產生的複雜物件 
public class Product
{
    private List<string> m_Part = new List<string>();
    
    public void AddPart(string Part)
    {
        m_Part.Add(Part);
    }
    public void ShowProduct()
    {
        Debug.Log("ShowProduct Functions:");
        foreach (string Part in m_Part)
            Debug.Log(Part);
    }
}

// 介面用來生成Product的各零件
public abstract class builder
{
    public abstract void BuildPart1(Product theProduct);
    public abstract void BuildPart2(Product theProduct);
}

// Builder介面的具體實作A
public class ConcreteBuilderA : builder
{
    public override void BuildPart1(Product theProduct)
    {
        theProduct.AddPart("產品A_1");
    }
    public override void BuildPart2(Product theProduct)
    {
        theProduct.AddPart("產品A_2");
    }
}

// Builder介面的具體實作B
public class ConcreteBuilderB : builder
{
    public override void BuildPart1(Product theProduct)
    {
        theProduct.AddPart("產品B_1");
    }
    public override void BuildPart2(Product theProduct)
    {
        theProduct.AddPart("產品B_2");
    }
}

// 利用Builder介面來建構物件
public class Director
{
    private Product m_Product;

    public Director() { }

    // 建立 
    public void Construct(builder theBuilder)
    {
        // 利用Builder產生各部份加入Product中
        m_Product = new Product();
        theBuilder.BuildPart1(m_Product);
        theBuilder.BuildPart2(m_Product);
    }

    // 取得成品
    public Product GetResult()
    {
        return m_Product;
    }
}

