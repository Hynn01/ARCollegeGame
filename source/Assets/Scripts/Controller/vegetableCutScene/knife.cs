using UnityEngine;
using System.Collections;

public class knife : MonoBehaviour
{
    private LineRenderer myLinRenderer;     //该游戏对象的LineRenderer组件

    private int count;           //LineRenderer中position的数量
    private static float timeInterval;     //每隔interval时间记录一次鼠标的坐标
    private float time;
    // Use this for initialization
    void Start()
    {
        count = 0;
        timeInterval = 0.3f;
        myLinRenderer = GetComponent<LineRenderer>();
    }

    // Update is called once per frame
    void addline()
    {
        Vector3 pos = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y,10));    //切换到世界坐标系
        myLinRenderer.SetVertexCount(++count);
        myLinRenderer.SetPosition(count - 1, pos);
        if (count == 5)                                                 //清除刀痕 保证刀痕不能一直存在 无限延长
            myLinRenderer.SetVertexCount(count = 0);
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))      //当鼠标左键按下的时候记录第一个点
        {
            Debug.Log("Input.GetMouseButtonDown(0)");
            myLinRenderer.SetVertexCount(count = 0);               //先清除之前未清除的刀痕
            //GetComponent<AudioSource>().Play();
            time = timeInterval;
            addline();
        }
        else if (Input.GetMouseButton(0))          //鼠标按下时每隔interval秒记录一个点
        {
            time -= Time.deltaTime;
            if (time <= 0)
            {
                addline();
                time = timeInterval;
            }
        }
        else if (Input.GetMouseButtonUp(0))           //松开鼠标记录linerenderer的最后一个点
        {
            addline();
            time = timeInterval;                   //松开后interval秒清除刀痕
        }
        else
        {
            time -= Time.deltaTime;                //松开后interval秒清除刀痕
            if (time <= 0)
                myLinRenderer.SetVertexCount(count = 0);
        }

    }
}