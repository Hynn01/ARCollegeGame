using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class vegetableFly : MonoBehaviour
{
    //初始化
    //水果数组
    public GameObject[] fruits;

    //水果出现的间隔时间
    private static float interval;

    private float time;

    // Start is called before the first frame update
    void Start()
    {
        interval = 0.9f;
        //重复隔interval个时间出现一个水果
        InvokeRepeating("Create",interval,interval);

    }

    void Create() {
        float y = -5.75f;
        float x = Random.Range(-6.5f,6.5f); //随机水果出现的x坐标
        GameObject fruit = Instantiate(fruits[Random.Range(0,fruits.Length)]) as GameObject;
        fruit.transform.position = new Vector3(x,y,0);
        //根据x坐标决定水果飞行的带方向的初始速度范围
        float xSpeed = 0f;
        if (x <= -3f)
            xSpeed = Random.Range(2f, 4f);
        else if (x < 3f)
            xSpeed = Random.Range(-1f, 1f);
        else
            xSpeed = Random.Range(-4f,2f);
        //通过rigidbody2D组件给水果一个初始速度
        fruit.GetComponent<Rigidbody2D>().velocity = new Vector2(xSpeed,14f);

    }

    //// Update is called once per frame
    //void Update()
    //{
        
    //}
}
