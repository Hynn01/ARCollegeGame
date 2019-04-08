using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

//arCamera的点击事件
public class arClick : MonoBehaviour {

    public IBackPackService backpackService;

    //初始化
    void Start () {
        backpackService = new BackpackService();
    }
	
	//点击监听
	void Update () {
        if (Input.GetMouseButtonDown(0))
        {   //判断是否是点击事件
            Ray ray = Camera.main.ScreenPointToRay (Input.mousePosition);
            RaycastHit hitInfo;
            if (Physics.Raycast(ray,out hitInfo) )
            {
                testClick("1-tomato", hitInfo);
                testClick("2-egg", hitInfo);
            }
        }
	}
    void testClick(string tag , RaycastHit hitInfo)
    {
        if (hitInfo.transform.CompareTag(tag))
        {
            GameObject toBeDestroyed = GameObject.FindGameObjectWithTag(tag);
            if (toBeDestroyed != null)
            {
                toBeDestroyed.GetComponent<SpriteRenderer>().sprite = null;
                //Destroy(toBeDestroyed);
                addFoodToDatabase(tag);
                
            }
        }
    }


    void addFoodToDatabase(string name)
    {
        string id = name.Split('-')[0];
        backpackService.addItem(id);
    }
}
