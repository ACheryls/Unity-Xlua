using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using XLua;
/// <summary>
/// Lua�ⲿ�����ļ�
/// </summary>
public class HelloWorldByFile : MonoBehaviour
{
    private void Start()
    {
        //���ַ�ʽ����ִ��
        print("--------Resources.Load-----------");
        //1.ͨ��Resources.Load����
        TextAsset txt = Resources.Load<TextAsset>("HelloWorld.lua"); //����HelloWorld.lua.txt�ļ�
        print(txt.ToString());
        LuaEnv env = new LuaEnv();
        env.DoString(txt.ToString());


        print("--------require����-----------");
        //2.�ؼ���require
        env.DoString("require 'HelloWorld'"); //����HelloWorld.lua.txt�ļ�
        env.Dispose();
    }
}
