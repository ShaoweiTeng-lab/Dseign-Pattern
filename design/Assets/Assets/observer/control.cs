using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace observer {
    public class control : MonoBehaviour
    {
        SubjectEflow subject_ = new SubjectEflow();
        ConcreteObserver1 ConcreteObserver1_ = new ConcreteObserver1();
        ConcreteObserver2 ConcreteObserver2_ = new ConcreteObserver2();
        // Start is called before the first frame update
        void Start()
        {
            subject_.Attach(ConcreteObserver1_);
            subject_.Attach(ConcreteObserver2_);

            subject_.Notify("玩家收傷了",5);
            subject_.Notify("玩家打鬥中",20);
        }

        // Update is called once per frame
        void Update()
        {
        
        }
    }
} 
