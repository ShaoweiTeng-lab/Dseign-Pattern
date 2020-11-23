using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class state {

    public abstract void handle( );
    public abstract void change( Context _Context);
    public abstract void Q();
  
}
public class fly : state
{
    public override void change(Context _Context)
    {
        _Context.set_state(new run());

    }

    

    public override void handle( )
    {
        Debug.Log("fly");
    }

    public override void Q()
    {
        Debug.Log("fly Q");
    }

   
}
public class run : state
{
    public override void change(Context _Context)
    {
        _Context.set_state(new attack());

    }
 
    public override void handle( )
    {
         
        Debug.Log("run ");
    }

    public override void Q()
    {
         Debug.Log("run Q");
    }

   
}

public class attack : state
{
    public override void change(Context _Context)
    {
        _Context.set_state(new fly());
    }

     

    public override void handle( )
    {
        Debug.Log("attack");
    }

    public override void Q()
    {
        Debug.Log("attack Q");
    }

  
}
public class Context
{
    state _state;


    public Context(state new_state)
    {
        this._state = new_state;

    }
    public void set_state(state new_state) {
        this._state = new_state;

    }
    public void change( ) {
        
        _state.change(this);
       
    }
    public void sendall()
    {

        _state.handle();

    }
    public void Q()
    {

        _state.Q();

    }
}