using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace template
{
    public class control : MonoBehaviour
    {
        Template EnemyA_ = new EnemyA();
        Template EnemyB_ = new EnemyB();
        // Start is called before the first frame update
        void Start()
        {
            EnemyA_.TemplateMethod();
            EnemyB_.TemplateMethod();
        }

        // Update is called once per frame
        void Update()
        {

        }
    }
}
