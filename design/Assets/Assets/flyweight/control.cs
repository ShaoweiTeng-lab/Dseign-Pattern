using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Flyweight
{
    public class control : MonoBehaviour
    {
        //負責產生Flyweight的工廠
        FlyweightFactor FlyweightFactor_ = new FlyweightFactor();
        // 取得一個共用元件
        flyweight theFlyweight;
        player player_;
        // Start is called before the first frame update
        void Start()
        {
            theFlyweight = FlyweightFactor_.Get_flyweight("士兵係數all", 100, 50);
            player_ = new player(theFlyweight);

            player_.getdata();
        }

        // Update is called once per frame
        void Update()
        {

        }
    }



}
public class player
{


    flyweight theFlyweight;

    public int maxhp;
    public float movespeed;
    public player(flyweight theFlyweight)
    {
        this.theFlyweight = theFlyweight;
        maxhp = theFlyweight.GetMaxHP();
        movespeed = theFlyweight.GetMoveSpeed();

    }
    public void getdata(){
        Debug.Log(string.Format("MaxHp : {0} , MoveSpeed : {1}  ", maxhp, movespeed));

    }



}