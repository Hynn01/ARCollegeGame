using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoginService:ILoginService{
    UserDao userDao;
    public LoginService()
    {
        userDao = new UserDao();
        userDao.Start();
    }
    public void findPassword(User user)
    {
        throw new System.NotImplementedException();
    }

    public bool login(string name, string password)
    {
        if (userDao.isUserExists(name, password) != null)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    public bool logout()
    {
        throw new System.NotImplementedException();
    }

    public bool register(User user)
    {
        throw new System.NotImplementedException();
    }
}
