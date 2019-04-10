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
        Debug.Log("初始化存档");
        fullPath = Application.dataPath + "/doc";
        filePath = Application.dataPath + "/doc/process.json";
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
        if (!Directory.Exists(fullPath))
        {
            Directory.CreateDirectory(fullPath);
            if (!File.Exists(filePath))
            {
                File.Create(filePath);
            }
        }
        File.WriteAllText(filePath, jsonStr.ToString());
    }

    //读档
    public static BackPack read()
    {
        if (File.Exists(filePath))
        {
            backPack = JsonMapper.ToObject<BackPack>(File.ReadAllText(filePath));
            FileStream fs = new FileStream(filePath, FileMode.Open);
            fs.Close();
        }
        if (backPack != null)
        {
            return backPack;
        }
        return new BackPack();
    }
}
