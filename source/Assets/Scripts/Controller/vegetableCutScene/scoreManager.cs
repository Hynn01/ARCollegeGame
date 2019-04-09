using UnityEngine;
using System.Collections;

public class scoreManager : MonoBehaviour
{
    //public GameObject DObj;              //所有数字对应的  预制对象（tag需要手动添加并更改为score,方便下面销毁）
    public GameObject[] sDigits;

    public static int score = 0;
    // Use this for initialization
    void Start()
    {
        score = 0;
        setScore(score);
    }

    void setScore(int newScore)
    {
        //先删除已存在的数字
        GameObject[] objs = GameObject.FindGameObjectsWithTag("score");
        foreach (GameObject i in objs)
        {
            Debug.Log("Destroy(i)" + i);
            Destroy(i);
        }

        score += newScore;

        string str = score.ToString();
        int cnt = 0;
        //逐个数字实例化预制对象
        foreach (char ch in str)
        {
            Debug.Log("Instantiate(tDigits[ch - '0']):" + (sDigits[ch - '0']));
            //GameObject dobj = Instantiate(tDObj) as GameObject;
            //dobj.GetComponent<SpriteRenderer>().sprite = tDigits[ch - '0'];            //贴上对应的贴图
            GameObject dobj = Instantiate(sDigits[ch - '0']) as GameObject;
            dobj.transform.localScale = new Vector3(0.5f, 0.5f, 0.5f);
            dobj.transform.position = new Vector3(0.2f+0.3f * cnt, 4.5f, 0);
            ++cnt;
        }
    }
}