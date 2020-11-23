using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Template  //定義樣板
{//使用時機:若有多數程式碼使用相同流程 即將流程定義為Abstract
    // 定義完整演算法各步驟及執行順序

    public void TemplateMethod()
    {
        AutoAttack();
        MagicAttack();
    }
    protected abstract void AutoAttack();
    protected abstract void MagicAttack();

}
public class EnemyA : Template
{
    protected override void AutoAttack()
    {
        Debug.Log("EnemyA 使出   AutoAttack  ");
    }

    protected override void MagicAttack()
    {
        Debug.Log("EnemyA 使出   MagicAttack  ");
    }
}
public class EnemyB : Template
{
    protected override void AutoAttack()
    {
        Debug.Log("EnemyB 使出   AutoAttack  ");
    }

    protected override void MagicAttack()
    {
        Debug.Log("EnemyB 使出   MagicAttack  ");
    }
}
