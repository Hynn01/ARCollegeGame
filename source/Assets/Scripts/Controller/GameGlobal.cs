using LitJson;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using UnityEngine;
/*
* 游戏全局变量(即游戏进度)
*/
public class GameGlobal : MonoBehaviour
{
    //用户背包
    public static BackPack backPack;
    //当前关卡
    public static int curGameLevel;
    public static string fullPath;
    public static string filePath;
    private void Start()
    {
#if UNITY_EDITOR
        Debug.Log("初始化存档");
        fullPath = Application.dataPath + "/doc";
        filePath = Application.dataPath + "/doc/process.json";
#elif UNITY_ANDROID
        filePath = Application.persistentDataPath + "/"+"process.json";
#endif
        initBackPack();
    }
    //从存档中获取背包信息并加载
    public static void initBackPack()
    {
        backPack = read();
    }

    //存档
    public static void save()
    {
        JsonData jsonStr = JsonMapper.ToJson(backPack);
#if UNITY_EDITOR
        if (!Directory.Exists(fullPath))
        {
            Directory.CreateDirectory(fullPath);
            if (!File.Exists(filePath))
            {
                File.Create(filePath).Close();
            }
        }
#elif UNITY_ANDROID
        if (!File.Exists(filePath))
        {
            File.Create(filePath).Close();
        }
#endif
        File.WriteAllText(filePath, jsonStr.ToString());
    }

    //读档
    public static BackPack read()
    {
        if (File.Exists(filePath))
        {
            backPack = JsonMapper.ToObject<BackPack>(File.ReadAllText(filePath));
        }
        if (backPack != null)
        {
            return backPack;
        }
        return new BackPack();
    }
}
