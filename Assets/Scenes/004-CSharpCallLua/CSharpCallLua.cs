using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using UnityEngine;
using XLua;

public class CSharpCallLua : MonoBehaviour
{
    class Person 
    {
        public string name;
        public int age;

        public int id;
    }
    private void Start()
    {
        //LuaEnv env= new LuaEnv();
        //env.DoString("require 'CSharpCallLua'");

        //int a = env.Global.Get<int>("a");
        //print(a);
        //string b = env.Global.Get<string>("b");
        //print(b);
        //bool c = env.Global.Get<bool>("c");
        //print(c);

        //env.Dispose();

        LuaEnv env = new LuaEnv();
        env.DoString("require 'CSharpCallLua'");
        Person p = env.Global.Get<Person>("person");
        print(p.name + "-" + p.age); //输出 siki-100
        print(p.id);// 如果没有对应的数据，则输出0
        p.name = "SikiEdu";//此处不能修改.txt中的name
        env.DoString("print(person.name)");  //输出 LUA: siki
        env.Dispose();
        
    }
   
}
