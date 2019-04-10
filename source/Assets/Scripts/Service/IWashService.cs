using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/*
* 负责洗菜逻辑
*/
public interface IWashService{
    //洗菜(内部添加评分机制)
    void wash(List<FoodMaterial> items);
    //获取洗菜得分
    int getScore();
}
