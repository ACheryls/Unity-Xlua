using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using XLua;
public class CSharpCallLuaByFunc : MonoBehaviour
{
    private void Start()
    {
        //LuaEnv env = new LuaEnv();
        //env.DoString("require 'Func'");


        //print("**********�޷���ֵ���޴��κ���*****************");
        //Action act = env.Global.Get<Action>("PrintStr");
        //act();
        //act = null;


        //print("**********���κ���*****************");
        //Add add = env.Global.Get<Add>("Add");
        //add(55, 45);
        //add = null;

        //print("**********���κ���,�������ֵ*****************");
        //MultiplyResultFunc multiply = env.Global.Get<MultiplyResultFunc>("MultiplyResultFunc");
        //int resA;
        //int resB;
        //multiply(55, 45, out resA, out resB);
        //print(resA + "---" + resB);

        //multiply = null;

        //env.Dispose();

        LuaEnv env = new LuaEnv();
        env.DoString("require 'Func'");

        LuaFunction func = env.Global.Get<LuaFunction>("Add");
        object[] os = func.Call(1, 2); //os�Ƿ��صĽ�����û�н���򷵻�null
        if (os != null)
        {
            foreach (object o in os)
            {
                print(o);
            }
        }
        else
        {
            print("osΪ��");
           
        }
       
    }

    [CSharpCallLua]
    delegate void Add(int a, int b);
    [CSharpCallLua]
    delegate void MultiplyResultFunc(int a, int b, out int resultA,out int resultB);

}
