using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;
using UnityEngine.UI;

public class timeManager : MonoBehaviour
{
    //public GameObject text;
    public int TotalTime = 30;

    // public GameObject tDObj;              //所有数字对应的  预制对象（tag需要手动添加并更改为score,方便下面销毁）
    public GameObject[] tDigits;           //每个数字对应的贴纸

    private bool over = false;
    Transform outImage00;

    void Start()
    {
        over = false;
        StartCoroutine(CountDown());
    }

    IEnumerator CountDown()
    {
        while (TotalTime >= 0)
        {
            //text.GetComponent<Text>().text = TotalTime.ToString();
            setTime(TotalTime);
            //Thread.Sleep(1000);
            if (TotalTime != 0)
            {
                yield return new WaitForSeconds(1);
            }
            else
            {
                Time.timeScale = 0;//停止游戏
                //GameObject.Find("outImage").GetComponent<outImage>().onShow();//弹出分数提示栏，结束游戏
                //GameObject.Find("outEnsure").GetComponent<outImage>().onShow();//弹出分数提示栏，结束游戏
                //gradeShow.onShow();
            }

            //Invoke("TestFunc", 1f);
            TotalTime--;
        }
        //yield return null;

    }

    private void Update()
    {
        if (TotalTime <= 0 && over == false)
        {
            Debug.Log("over==false");
            over = true;
            //outImage.outWindow.onShow();
            //if (GameObject.FindWithTag("outImageTag"))
            //{
            //    Debug.Log("GameObject.FindGameObjectWithTag(outImageTag)");
            //}
            if (GameObject.Find("outCanvas"))
            {
                Debug.Log("gameObject.transform.Find(outCanvas)");
            }

            if (GameObject.Find("outCanvas/outImage"))
            {
                Debug.Log("gameObject.transform.Find(outCanvas/outImage)");
            }

            Transform outImage00 = gameObject.transform.Find("outCanvas/outImage");
            //outImage00.gameObject.GetComponent<outWindow>().onShow();//弹出分数提示栏，结束游戏
            Debug.Log("233333333333333");
            //.GetComponent<outWindow>().onShow();//弹出分数提示栏，结束游戏

            //加载预设体资源
            GameObject outPop = (GameObject)Resources.Load("Prefabs/outCanvas");
            GameObject outp = Instantiate(outPop) as GameObject;
            //outp.transform.position = new Vector3(0,0,0);
        }
    }

    void setTime(int newTime)
    {

        //先删除已存在的数字
        GameObject[] objs = GameObject.FindGameObjectsWithTag("time");
        foreach (GameObject i in objs)
        {
            Debug.Log("Destroy(i)" + i);
            Destroy(i);
        }

        string str = TotalTime.ToString();
        int cnt = 0;
        //逐个数字实例化预制对象
        foreach (char ch in str)
        {
            Debug.Log("Instantiate(tDigits[ch - '0']):" + (tDigits[ch - '0']));
            //GameObject dobj = Instantiate(tDObj) as GameObject;
            //dobj.GetComponent<SpriteRenderer>().sprite = tDigits[ch - '0'];            //贴上对应的贴图
            GameObject dobj = Instantiate(tDigits[ch - '0']) as GameObject;
            dobj.transform.localScale = new Vector3(0.5f, 0.5f, 0.5f);
            dobj.transform.position = new Vector3(0.2f+0.3f * cnt, 4, 0);
            ++cnt;
        }


    }

}
