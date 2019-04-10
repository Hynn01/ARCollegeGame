using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/*
* 游戏关卡类
*/
public class GameLevel{
    //关卡ID
    private int levelID { get; set; }
    //菜谱ID
    private int menuID { get; set; }
    //关卡得分
    private int score { get; set; }
    //关卡是否通过
    private bool state { get; set; }
}
