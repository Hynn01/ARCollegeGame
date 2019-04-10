using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class login_button : MonoBehaviour {
    InputField account;
    InputField password;
    Text text;
    private ILoginService loginService;
    void Start()
    { 
        password = GameObject.Find("input_password").GetComponent<InputField>();
        account = GameObject.Find("input_name").GetComponent<InputField>();
        text = GameObject.Find("Text").GetComponent<Text>();
        Button btn = this.GetComponent<Button>();
        btn.onClick.AddListener(OnClick);
    }
    private  void OnClick()
    {
        loginService = new LoginService();
        string name = account.text.ToString();
        string passwd = password.text.ToString();
        //try
        //{
            if (loginService.login(name, passwd))
            {
                Debug.Log("登录成功！");
                //跳转到主页
                SceneManager.LoadScene("mainScene");
            }
            else
            {
                Debug.Log("登录失败！");
            }
        //}
        //catch(Exception e)
        //{
        //    Debug.Log(e.Message);
        //}
    }
}
