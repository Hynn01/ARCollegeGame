using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/*
* 负责切菜逻辑
*/
public interface ICutService{
    //切菜(内部添加评分机制)
    void cut(List<FoodMaterial> items);
    //获取切菜得分
    int getScore(); 
    //随机添加干扰项
    void addObstructions();
}
