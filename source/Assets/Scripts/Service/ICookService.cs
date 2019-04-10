using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/*
* 负责做菜逻辑
*/
public interface ICookService{
    //做菜(内部添加评分机制)
    void cook(List<FoodMaterial> items);
    //启动烹饪工具
    void start(Vessel vessel);
    //关闭烹饪工具(到达设置的烹饪时间时调用关闭方法)
    void stop(Vessel vessel);
    //设置烹饪时间
    void setTime(int cookTime);
    //添加调料(调料名称及分量)
    void addFlavor(string name, int count);
    //获取做菜得分
    int getScore();
}
