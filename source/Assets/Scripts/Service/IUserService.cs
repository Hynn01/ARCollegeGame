using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/*
* 负责用户管理
*/
public interface IUserService{
    //添加账户
    bool addUser(User user);
    //切换账户
    void changeUser();
    //注销账户(删除账号)
    void writtenOff(User user);
    //修改个人信息
    void update(User user);
}
