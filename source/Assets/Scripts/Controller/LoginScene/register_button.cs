using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class register_button : MonoBehaviour
{
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
    private void OnClick()
    {
        loginService = new LoginService();
        string name = account.text;
        string passwd = password.text;
        User user = new User();
        user.name = name;
        user.password = passwd;
        try
        {
            if (loginService.register(user))
            {
                Debug.Log("注册成功！");
                //跳转到主页
                SceneManager.LoadScene("mainScene");
            }
            else
            {
                Debug.Log("注册失败！");
            }
        }
        catch (Exception e)
        {
            Debug.Log(e.Message);
        }
    }
}
