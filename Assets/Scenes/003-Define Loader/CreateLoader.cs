using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using XLua;
using System.IO;
/// <summary>
/// �Զ���Lua��require�ļ���·��
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
    /// �Զ���require����·����������Ϊnull�������luaϵͳ��Ĭ�ϼ���
    /// </summary>
    /// <param name="filePath"></param>
    private byte[] MyLoader(ref string filePath)
    {
        print("Ҫ���ʵ�·������:" + filePath);
        print(Application.streamingAssetsPath);
        string absPath = Application.streamingAssetsPath + "/" + filePath+".lua.txt"; 
        return System.Text.Encoding.UTF8.GetBytes(File.ReadAllText(absPath));
    }
}
