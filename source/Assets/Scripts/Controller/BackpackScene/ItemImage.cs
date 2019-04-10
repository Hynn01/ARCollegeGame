using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemImage : MonoBehaviour {

    //实际多是图片，可以使用这个更新图片
    //public Text itemNum;
    public Image image1;

    //////本节以字体为例

    //public void UpdateItemNum(string itemNum)
    //{

    //    itemText.text = itemNum;

    //}

    public void UpdateItemImage(Sprite icon)

    {
        image1.sprite = icon;
        Debug.Log("test1");
    }
}
