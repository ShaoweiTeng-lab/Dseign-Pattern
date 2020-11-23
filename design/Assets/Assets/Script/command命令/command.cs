using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public  abstract  class command {//命令abstract
    
    public abstract void dothing( );
}

public  class Invoke{//執行命令者
    List<command> m_Commands = new List<command>();//收集全部命令

    public  void addCommands(command command_) {

        m_Commands.Add(command_);
    }
    public void action() {

        foreach (command command_ in m_Commands) {

            command_.dothing();//執行全部命令
        }
       
        m_Commands.Clear();//清空命令(不一定執行)
        

    }
}
public   class Receiver : command//不同命令繼承
{
       

    public override void dothing( )
    {
        Debug.Log("Receiver action");
    }
}
public class Receiver1 : command
{


    public override void dothing()
    {
        Debug.Log("Receiver1 action");
    }
}