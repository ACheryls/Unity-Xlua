using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using XLua;
using System.IO;
/// <summary>
/// 自定义Lua中require的加载路径
/// </summary>
public class CreateLoader : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        LuaEnv env = new LuaEnv();
        env.AddLoader(MyLoader);
        env.DoString("require 'LoaderTest'");
        env.Dispose();
        
    }
    /// <summary>
    /// 自定义require加载路径，如果输出为null，则调用lua系统的默认加载
    /// </summary>
    /// <param name="filePath"></param>
    private byte[] MyLoader(ref string filePath)
    {
        print("要访问的路径名字:" + filePath);
        print(Application.streamingAssetsPath);
        string absPath = Application.streamingAssetsPath + "/" + filePath+".lua.txt"; 
        return System.Text.Encoding.UTF8.GetBytes(File.ReadAllText(absPath));
    }
}
