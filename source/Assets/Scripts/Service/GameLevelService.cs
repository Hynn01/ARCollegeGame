using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/*
* 负责闯关逻辑
*/
public class GameLevelService {
    //关卡菜谱
    public Menu menu { set; get; }
    //关卡分数
    public int score { set; get; }
    //洗菜服务
    IWashService washService;
    //切菜服务
    ICutService cutService;
    //做菜服务
    ICookService cookService;
    //控制闯关逻辑(闯关过程)
    public void advance()
    {

    }
    //初始化关卡(初始化菜谱，分数等)
    public void initGameLevel()
    {

    }
}
