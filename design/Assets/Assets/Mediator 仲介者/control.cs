using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace mediator
{
    public class control : MonoBehaviour
    {
        Mediator mediator;
        medic medic_;
        actor actor_;
        [SerializeField]
        InfantryColleagueall InfantryColleagueall_;
        // Start is called before the first frame update
        void Start()
        {
            mediator = new Mediator();
            medic_ = new medic(mediator);
            actor_ = new actor(mediator);
        }

        // Update is called once per frame
        void Update()
        {
            if (Input.GetKeyDown(KeyCode.Q)) {
                InfantryColleagueall_ = InfantryColleagueall.hurt;
                mediator.getandsendmessage(InfantryColleagueall_, "士兵遭到攻擊");
            }
            if (Input.GetKeyDown(KeyCode.W))
            {
                InfantryColleagueall_ = InfantryColleagueall.attack;
                mediator.getandsendmessage(InfantryColleagueall_, "接到上級的命令");
            }
            if (Input.GetKeyDown(KeyCode.E))
            {
                InfantryColleagueall_ = InfantryColleagueall.normal;
                mediator.getandsendmessage(InfantryColleagueall_, "風吹過");
            }

        }
    }
}
