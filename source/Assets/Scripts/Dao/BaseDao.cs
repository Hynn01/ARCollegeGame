using UnityEngine;
using System.Collections;
using System.IO;
/*
* Dao层基类
*/
public class BaseDao{
    public string appDBPath;
    public SQLiteHelper sh;
    public string TABLE_NAME;
    //初始化数据库工具
    public void Start()
    {
        //如果运行在编辑器中
#if UNITY_EDITOR
        //通过路径找到第三方数据库
        appDBPath = Application.dataPath + "/Resources/" + "GameDB.db";
        sh = new SQLiteHelper("URI=file:" + appDBPath);
        //如果运行在Android设备中
#elif UNITY_ANDROID
        //将第三方数据库拷贝至Android可找到的地方
        appDBPath = Application.persistentDataPath + "/" + "GameDB.db";
        //如果已知路径没有地方放数据库，那么从Unity中拷贝
		if(!File.Exists(appDBPath))
 		{
            TextAsset txt = Resources.Load("GameDB",typeof(TextAsset))as TextAsset;
			//拷贝至规定的地方
		    File.WriteAllBytes(appDBPath, txt.bytes);
		}
		//在这里重新得到db对象。
		sh = new SQLiteHelper("URI=file:" + appDBPath);
#endif
    }
}
