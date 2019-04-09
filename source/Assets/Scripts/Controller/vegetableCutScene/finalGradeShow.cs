using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class finalGradeShow: MonoBehaviour
{
    int score;
    public GameObject[] sDigits;
    // Start is called before the first frame update
    void Start()
    {
        //gameObject.SetActive(false);
        score = scoreManager.score;
        string str = score.ToString();
        int cnt = 0;
        //逐个数字实例化预制对象
        foreach (char ch in str)
        {
            GameObject dobj = Instantiate(sDigits[ch - '0']) as GameObject;
            dobj.transform.localScale = new Vector3(0.5f, 0.5f, 0.5f);
            dobj.transform.localPosition = new Vector3(-0.1f + 0.3f * cnt, 0.2f, 0);
            dobj.transform.parent = this.transform;
            ++cnt;
        }


    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //public void onShow() {
    //    gameObject.SetActive(true);
    //}

    public void onEnsure() {
        gameObject.SetActive(false);
        SceneManager.LoadScene("cuttingScene");
    }
}
