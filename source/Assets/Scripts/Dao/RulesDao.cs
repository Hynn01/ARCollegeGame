using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/*
* 规则数据库接口
*/
public class RulesDao:BaseDao{
    public RulesDao(): base()
    {
        base.Start();
        TABLE_NAME = "rules";
    }
    //根据规则ID查询规则
    public Rule selectRuleByRuleID(string ID)
    {
        return new Rule();
    }
}
