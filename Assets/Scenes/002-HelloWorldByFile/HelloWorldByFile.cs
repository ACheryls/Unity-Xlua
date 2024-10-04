using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using XLua;
/// <summary>
/// Lua外部加载文件
/// </summary>
public class HelloWorldByFile : MonoBehaviour
{
    private void Start()
    {
        //两种方式加载执行
        print("--------Resources.Load-----------");
        //1.通过Resources.Load加载
        TextAsset txt = Resources.Load<TextAsset>("HelloWorld.lua"); //加载HelloWorld.lua.txt文件
        print(txt.ToString());
        LuaEnv env = new LuaEnv();
        env.DoString(txt.ToString());


        print("--------require加载-----------");
        //2.关键字require
        env.DoString("require 'HelloWorld'"); //加载HelloWorld.lua.txt文件
        env.Dispose();
    }
}
