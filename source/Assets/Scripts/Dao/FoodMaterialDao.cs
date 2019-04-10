using Mono.Data.Sqlite;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/*
* 食材数据库接口
*/
public class FoodMaterialDao:BaseDao{
    public void Start()
    {
        base.Start();
        TABLE_NAME = "food_material";
    }
    //根据食材ID获取食材
    public FoodMaterial selectFoodMaterialByID(int ID)
    {
        Debug.Log("食材ID"+ID);
        string sql = "select * from " + TABLE_NAME + " where id = " + ID;
        SqliteDataReader sdr = sh.ExecuteQuery(sql);
        if (sdr.Read() == false)
        {
            Debug.Log("false");
            return null;
        }
        else
        {
            Debug.Log("true");
            FoodMaterial fm = new FoodMaterial();
            fm.id = ID;
            fm.name = sdr["name"].ToString();
            fm.beforeImgPath = sdr["before_img"].ToString();
            fm.afterImgPath = sdr["after_img"].ToString();
            fm.category = sdr["category"].ToString();
            return fm;
        }
    }
}
