using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/*
* 负责游戏进度保存，待完善
*/
public interface ISaveService{
    //保存游戏进度
    void save();
    //删除存档
    void delete();
    //加载存档
    void load();
}
