using Mono.Data.Sqlite;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
/*
* 用户数据库接口
*/
public class UserDao:BaseDao{
    public void Start()
    {
        base.Start();
        TABLE_NAME = "user";
    }
    //判断用户名密码是否正确
    public User isUserExists(string name = "", string password = "")
    {
        string sql = "select * from "+TABLE_NAME+" where name = '" + name + "' and password = '"+password+"'";
        SqliteDataReader sdr = sh.ExecuteQuery(sql);
        if (sdr.Read()==false)
        {
            return null;
        }
        else
        {
            User user = new User();
            user.id = int.Parse(sdr["id"].ToString());
            user.name = sdr["name"].ToString();
            user.imagePath = sdr["imagePath"].ToString();
            user.acid = int.Parse(sdr["acid"].ToString());
            user.sweet = int.Parse(sdr["sweet"].ToString());
            user.fresh = int.Parse(sdr["fresh"].ToString());
            user.spicy = int.Parse(sdr["spicy"].ToString());
            user.salty = int.Parse(sdr["salty"].ToString());
            user.province = sdr["province"].ToString();
            user.grade = int.Parse(sdr["grade"].ToString());
            return user;
        }
    }
    //判断用户是否存在
    public bool isUserNameExists(string name = "")
    {
        string sql = "select * from " + TABLE_NAME + " where name = '" + name+"'";
        if (sh.ExecuteQuery(sql).Read() == false)
        {
            return false;
        }
        else
        {
            return true;
        }
    }
    //插入新用户
    public void insertUser(User user)
    {
        string sql = "insert into " + TABLE_NAME + " (name, password, imagePath, acid, sweet, fresh, spicy, salty, province, grade )"+
            " VALUES( '" + user.name + "', '" + user.password + "', '" + user.imagePath
            + "'," + user.acid+", "+user.sweet+", "+user.fresh+", "+user.spicy+", "+user.salty+", '"+user.province+"', "+user.grade+" )";
        sh.ExecuteQuery(sql);
    }
    //更新用户信息
    public void updateUser(User user)
    {
        string sql = "update " + TABLE_NAME + "set name = '" + user.name + "', password = '" + user.password + "', imagePath = '" + user.imagePath + "', acid = " +
            user.acid + ", sweet = " + user.sweet + ", fresh = " + user.fresh + ", spicy" + user.spicy + ", salty = " + user.salty + ", province = '" + user.province + "', grade  = " + user.grade + 
            "where id = "+user.id;
        sh.ExecuteQuery(sql);
    }
    //删除用户
    public void DeleteUser(User user)
    {
        string sql = "delete from " + TABLE_NAME + "where id = " + user.id;
        sh.ExecuteQuery(sql);
    }
}
