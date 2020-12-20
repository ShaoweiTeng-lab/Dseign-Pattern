using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Handler {//處理訊習用abs
    protected Handler nexthandler;
    
     
    public virtual void nexthandlerPut(Handler nexthandler_) {

        this.nexthandler = nexthandler_;
    }
    public virtual void HandleRequest(int Cost) {//判斷值後確定要不要將直傳遞給下一位繼承abs者(判斷在繼承身上)
        if (nexthandler != null)
        {
            
            nexthandler.HandleRequest(Cost);
        }
    }
}
public class ConcreteHandler1 : Handler {

    public override void nexthandlerPut(Handler nexthandler_)
    {
       base.nexthandlerPut(nexthandler_);
    }
    public override void HandleRequest(int Cost)
    {
        if (Cost >= 10)
            base.HandleRequest(Cost);//cost 大於 執行父物件的方法->將值傳給下一位nexthandler判斷
        else
            Debug.Log("ConcreteHandler1已授權");
    }


}
public class ConcreteHandler2 : Handler
{

    public override void nexthandlerPut(Handler nexthandler_)
    {
        base.nexthandlerPut(nexthandler_);
    }
    public override void HandleRequest(int Cost)
    {
        if (Cost > 10)
            Debug.Log("由ConcreteHandler2接手 ，ConcreteHandler2已授權");//cost 大於 執行父物件的方法->將值傳給下一位nexthandler判斷
        
           
    }


}
