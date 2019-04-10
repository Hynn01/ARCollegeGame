using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/*
* 负责背包管理
*/
public interface IBackPackService{
    //列出背包内所有物品
    List<FoodMaterial> getAllItems();
    //添加物品(背包已满返回false)
    bool addItem(string itemID);
    //取出物品(参数待定)
    void getItem(string name);
    //丢弃物品(参数待定)
    void dropItem(string name);
}
