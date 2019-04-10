using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class vegetableCut : MonoBehaviour
{
    public GameObject obj1, obj2;    //分开后的两边水果
    public GameObject[] wz;          //几种污渍背景

    private BoxCollider2D col;
    private Vector2[] vec = { Vector2.left, Vector2.right };   //切后的半截往两个方向飞出
    private GameObject scores;     //放置scoreManager.cs和healthManager.cs脚本的游戏对象

    void Start()
    {
        col = GetComponent<BoxCollider2D>();
        scores = GameObject.Find("scoreManager");
    }

    private void CreateHalf(GameObject obj, int index)       //创建半个水果
    {
        obj = Instantiate(obj, transform.position, Quaternion.AngleAxis(Random.Range(-30f, 30f), Vector3.back)) as GameObject;
        Rigidbody2D rgd = obj.GetComponent<Rigidbody2D>();
        float v = Random.Range(2f, 4f);                        //随机飞出速度
        rgd.velocity = vec[index] * v;
        Destroy(obj, 2f);
    }
    private void Createwz()              //切开水果随机创建污渍
    {
        if (wz.Length == 0)              //仓鼠没有水果污渍
            return;
        GameObject obj = Instantiate(wz[Random.Range(0, wz.Length)], transform.position, Quaternion.AngleAxis(Random.Range(-30f, 30f), Vector3.back)) as GameObject;
        Destroy(obj, 1f);
    }
    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            Debug.Log("col.transform.position:" + col.transform.position);
            Vector3 touchPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            if (col.OverlapPoint(new Vector2(touchPosition.x, touchPosition.y))) ;                //鼠标在当前水果2Dcollider内
            {
                Debug.Log("scoresObject：" + scores);
                Debug.Log("name:" + name);
                if (name == "pork(Clone)")
                    scores.SendMessage("setScore", 5);
                else if (name == "eggplant(Clone)")
                    scores.SendMessage("setScore", 4);
                else if (name == "pepper(Clone)")
                    scores.SendMessage("setScore", 3);
                else if (name == "onion(Clone)")
                    scores.SendMessage("setScore", 2);
                else
                    scores.SendMessage("setScore", 1);
                CreateHalf(obj1, 0);
                CreateHalf(obj2, 1);
                Createwz();
                Destroy(this.gameObject);
            }
        }
        else if (this.transform.position.y <= -6f)         //水果掉落到范围外扣分自动销毁
        {
            //scores.SendMessage("setScore", -1);
            //Destroy(this.gameObject);
        }
    }
}
