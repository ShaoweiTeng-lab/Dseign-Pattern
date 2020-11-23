using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class facade
{
    #region 簡易
    //Light L1 = new Light("up");
    //TV _tv = new TV();
    #endregion
    #region 特殊用法
    //特殊用法

    public Facade.control _control;
    [SerializeField]
    playerall _player;

    public Material playerMaterial;
    #endregion
    public facade() { }

    public facade(Facade.control _control, Material _material)
    {
        this._control = _control;
        playerMaterial = _material;
        //初始物件 防止空物件
        GameObject player = _control.transform.gameObject;
        _player = new playerall(player, playerMaterial);


    }

    public void dothing()
    {
        //L1.ON();
        //_tv.ON();
        _player.move();

    }


}
public class Light
{
    /*位置*/
    private string position;

    public Light(string position)
    {
        this.position = position;
    }

    /*開燈*/
    public void ON()
    {
        Debug.Log(this.position + "開燈");
    }

    /*關燈*/
    public void OFF()
    {
        Debug.Log(this.position + "關燈");
    }
}

public class TV
{
    public void ON()
    {
        Debug.Log("開電視");
    }

    public void OFF()
    {
        Debug.Log("關電視");
    }
}
[System.Serializable]
public class playerall
{
    [SerializeField]
    GameObject _player;
    Material materal;
    public playerall(GameObject player, Material materal)
    {
        _player = player;
        this.materal = materal;
    }
    public void move()
    {

        _player.transform.Translate(Vector3.up * 5 * Time.deltaTime);

        _player.GetComponent<MeshRenderer>().material = materal;
    }

}
