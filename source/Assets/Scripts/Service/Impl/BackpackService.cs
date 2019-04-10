using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using LitJson;
using System.IO;

public class BackpackService : IBackPackService
{
    FoodMaterialDao foodMaterialDao;
    public BackpackService()
    {
        foodMaterialDao = new FoodMaterialDao();
        foodMaterialDao.Start();
    }
    //添加物品
    bool IBackPackService.addItem(string ItemID)
    {
        BackPack backPack = GameGlobal.backPack;
        if (backPack.Items.ContainsKey(ItemID))
        {
            backPack.Items[ItemID] += 1;
        }
        else
        {
            if (backPack.Items.Count < backPack.capacity)
            {
                backPack.Items.Add(ItemID, 1);
            }
            else
            {
                return false;
            }
        }
        // 更新存档
        GameGlobal.save();
        return true;
    }

    //返回所有物品
    List<FoodMaterial> IBackPackService.getAllItems()
    {
        List<FoodMaterial> foodMaterials = new List<FoodMaterial>();
        Dictionary<string, int>.KeyCollection keyCol = GameGlobal.backPack.Items.Keys;
        Debug.Log(keyCol.Count);
        foreach (string key in keyCol)
        {
            foodMaterials.Add(foodMaterialDao.selectFoodMaterialByID(int.Parse(key)));
        }
        return foodMaterials;
    }

    // 丢掉物品
    void IBackPackService.dropItem(string name)
    {
        throw new System.NotImplementedException();
    }

    // 获取物品信息
    void IBackPackService.getItem(string name)
    {
        throw new System.NotImplementedException();
    }
}
