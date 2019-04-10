using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class inImage : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //此函数接口将赋予“弹出对话框”按钮（即砧板）的onClick事件
    public void onShow() {
        gameObject.SetActive(true);
        Debug.Log("gameObject.SetActive(true)");
    }

    //此函数接口将赋予给"确认"按钮的onClick事件
    public void onOK() {
        gameObject.SetActive(false);
        SceneManager.LoadScene("vegetableCutScene");
    }

    //此函数接口将赋予给"取消"按钮的onClick事件
    public void onCancel() {
        gameObject.SetActive(false);
    }


}
