using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using XLua;

public class HelloWord01 : MonoBehaviour
{
    private LuaEnv luaEnv;
    // Start is called before the first frame update
    void Start()
    {
        luaEnv = new LuaEnv();

        luaEnv.DoString("print('Hello World')"); //打印字符串

        
        
        
    }

    private void OnDestroy()
    {
        luaEnv.Dispose(); //释放资源

    }
}
