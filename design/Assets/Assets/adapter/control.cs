using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Adapter
{
    public class control : MonoBehaviour
    {
        Target Target_ = new Adapter_();
        #region 寵物系統應用
        Monster Monster_ = new Monster("卡瑪", 10);
        Pat Pat_;

        #endregion
        // Start is called before the first frame update
        void Start()
        {
            // Target_.Request();正常用
            Pat();
        }

        // Update is called once per frame
        void Update()
        {

        }
        #region 寵物系統應用
        void Pat() {

            

          
            Monster_.SendDamage();
            Pat_ = new Pat(Monster_);
            Pat_.SendMessage();
            Pat_.Addlevel(10);
            Pat_.SendMessage();

        }
        #endregion
    }
}
