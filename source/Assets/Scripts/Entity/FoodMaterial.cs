using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/*
* 食材类
*/
public class FoodMaterial {
    //食材ID
    public int id { get; set; }
    //食材名称
    public string name { get; set; }
    //食材类别
    public string category { get; set; }
    //切之前图片
    public string beforeImgPath { get; set; }
    //切之后图片
    public string afterImgPath { get; set; }
    //食材当前状态的图片对象
    public Sprite image { get; set; }
    //食材状态
    public int state { get; set; }
    //初始化食材图片对象
    public void initImage()
    {
        image = Resources.Load<Sprite>(beforeImgPath);
    }
}
