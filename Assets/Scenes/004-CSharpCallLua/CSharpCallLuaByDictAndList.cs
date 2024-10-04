using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using XLua;
public class CSharpCallLuaByDictAndList : MonoBehaviour
{
    private void Start()
    {
        LuaEnv env = new LuaEnv();
        env.DoString("require 'DistAndListCallLua'");
        print("------------Dict------------------");
        Dictionary<string, object> dict = env.Global.Get<Dictionary<string, object>>("person");
        foreach (string key in dict.Keys)
        {
            print(key + "-" + dict[key]);
        }

        print("--------------List------------------");
        List<object> list = env.Global.Get<List<object>>("person");
        foreach (object obj in list)
        {
            print(obj); 
        }
        print("--------------List------int------------");
        List<int> listInt = env.Global.Get<List<int>>("person");
        foreach (object obj in listInt)
        {
            print(obj);
        }


        print("--------------List------str------------");
        List<string> listStr = env.Global.Get<List<string>>("person");
        foreach (object obj in listStr)
        {
            print(obj);
        }
        env.Dispose();

    }

}
