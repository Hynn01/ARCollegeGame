using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/*
* 用户类
*/
public class User {
    //用户id
    public int id { get; set;}
    //用户名
    public string name { get; set; }
    //密码
    public string password { get; set; }
    //头像路径
    public string imagePath { get; set; }
    //口味：酸
    public int acid { get; set; }
    //口味：甜
    public int sweet { get; set; }
    //口味：鲜
    public int fresh { get; set; }
    //口味：辣
    public int spicy { get; set; }
    //口味：咸
    public int salty { get; set; }
    //省份
    public string province { get; set; }
    //等级
    public int grade { get; set; }
}
