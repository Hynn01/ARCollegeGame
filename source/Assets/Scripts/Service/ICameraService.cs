using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/*
* 负责摄像头管理
*/
public interface ICameraService{
    //打开摄像头
    bool open();
    //关闭摄像头
    bool close();
}
