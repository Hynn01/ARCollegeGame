using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/*
* 负责地图管理
*/
public interface IMapService {
    //打开地图
    bool open();
    //关闭地图
    bool close();
}
