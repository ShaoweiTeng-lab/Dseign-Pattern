using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Decorator
{
    public class control : MonoBehaviour
    {
        Player Player_ = new Player(20);
        Wepon1 Wepon1_;
        Wepon2 Wepon2_;
        // Start is called before the first frame update
        void Start()
        {
            Wepon1_ = new Wepon1(Player_);
            Wepon1_.SendMessage();

            Wepon2_= new Wepon2(Player_);
            Wepon2_.SendMessage();
        }

        // Update is called once per frame
        void Update()
        {

        }
    }
}
