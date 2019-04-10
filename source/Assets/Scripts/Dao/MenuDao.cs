using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/*
* 菜谱数据库接口
*/
public class MenuDao:BaseDao{
    private string TABLE_NAME1;
    private string TABLE_NAME2;
    public MenuDao() : base()
    {
        base.Start();
        TABLE_NAME1 = "menu";
        TABLE_NAME2 = "menu_foodmaterial";
    }
    //根据菜谱ID查询菜谱
    public Menu selectMenuByID()
    {
        return new Menu();
    }
    //根据菜谱ID查询规则ID
    public int selectMenuByID(string id)
    {
        return 0;
    }
    //根据菜谱ID查询食材ID及数量列表
    public Dictionary<int,int> selectFoodMaterial(string id)
    {
        return new Dictionary<int,int>();
    }
}
 