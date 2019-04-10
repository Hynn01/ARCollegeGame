using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/*
* 负责登录注册逻辑
*/
public interface ILoginService{
    //登录
    bool login(string name,string password);
    //注册
    bool register(User user);
    //退出账号
    bool logout();
    //找回密码
    void findPassword(User user);
}
