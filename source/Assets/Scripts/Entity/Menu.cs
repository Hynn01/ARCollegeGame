using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/*
* 菜谱类
*/
public class Menu{
    //菜谱ID
    private string ID { get; set; }
    //所需食材
    private Dictionary<int, int> FoodMaterial { get; set; }
    //规则
    private Rule rules { get; set; }
}
