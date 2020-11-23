using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// 存放Originator物件的內部狀態 (備忘錄類)
public class memento
{
    string m_State;
    public string GetState()
    {
        return m_State;
    }

    public void SetState(string State)
    {
        m_State = State;
    }
}

// 需要儲存內容資訊
public class Originator
{
    string m_State; // 狀態,需要被保存

    public void SetInfo(string State)
    {
        m_State = State;
    }

    public void ShowInfo()
    {
        Debug.Log("Originator State:" + m_State);
    }

    // 產生要儲存的記錄
    public memento CreateMemento()
    {
        memento newMemento = new memento();
        newMemento.SetState(m_State);//修改 memnto 的 m_State
        return newMemento;
    }

    // 設定要回復的記錄
    public void SetMemento(memento m)
    {
        m_State = m.GetState();
    }
}

// 保管所有的Memento
public class Caretaker
{
    Dictionary<string, memento> m_Memntos = new Dictionary<string, memento>();

    // 增加
    public void AddMemento(string Version, memento theMemento)
    {
        if (m_Memntos.ContainsKey(Version) == false)
            m_Memntos.Add(Version, theMemento);
        else
            m_Memntos[Version] = theMemento;
    }

    // 取回
    public memento GetMemento(string Version)
    {
        if (m_Memntos.ContainsKey(Version) == false)
            return null;
        return m_Memntos[Version];
    }

}
