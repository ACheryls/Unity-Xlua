using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using XLua;

public class CSharpCallLuaByInterface : MonoBehaviour
{
    private void Start()
    {
        LuaEnv env = new LuaEnv();
        env.DoString("require 'CSharpCallLua'");
        IPerson person = env.Global.Get<IPerson>("person");
        print(person.name+"-" +person.age);

        person.name = "ChenHao";
        env.DoString("print(person.name)");
        person.eat(12, 34);
        env.Dispose();
    }
    [CSharpCallLua]
    public interface IPerson
    {
        string name { get; set; }
        int age { get; set; }
        void eat(int a, int b);
    }
}
