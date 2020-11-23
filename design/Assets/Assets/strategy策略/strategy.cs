using UnityEngine;
public abstract class strategy {
    public abstract void atk();

}
//與狀態模式state差異 為 class之間不認識彼此  (state0 與state1)
public class state0 : strategy
{
    public override void atk()
    {
        Debug.Log("state0atk");
    }
}

public class state1 : strategy
{
    public override void atk()
    {
        Debug.Log("state1atk");
    }
}

public class context {
    strategy strategy_;
    public context(strategy strategy_)
    {
        this.strategy_ = strategy_;
        
    }
    public void attack() {

        strategy_.atk();

    }


}


