using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackPackManager : MonoBehaviour
{
    //背包面板
    public GridPanel gridPanel;
    //背包管理服务
    private IBackPackService backPackService;
    private List<FoodMaterial> foodMaterials;

    void Awake()
    {
        LoadData();
    }

    //模拟数据库数据加载
    private void LoadData()
    {
        gridPanel = GameObject.Find("GridPanel").GetComponent<GridPanel>();
        backPackService = new BackpackService();
        foodMaterials = backPackService.getAllItems();
        foreach(var item in foodMaterials)
        {
            Transform emptyGrid = gridPanel.GetEmptyGrid();
            GameObject itemPrefab = Resources.Load<GameObject>("Prefabs/ItemImage");
            item.image = Resources.Load<Sprite>(item.beforeImgPath);
            Debug.Log(item.beforeImgPath);
            itemPrefab.GetComponent<ItemImage>().UpdateItemImage(item.image);
            GameObject itemGo = Instantiate(itemPrefab);
            itemGo.transform.SetParent(emptyGrid);
            itemGo.transform.localPosition = Vector3.zero;
            itemGo.transform.localScale = Vector3.one;
        }
    }
}
