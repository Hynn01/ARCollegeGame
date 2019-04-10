using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//未写好
//public class NewBehaviourScript : MonoBehaviour
//{
//    Vector3 startV;
//    Vector3 endV;

//    // Start is called before the first frame update
//    void Start()
//    {
        
//    }

//    // Update is called once per frame
//    void Update()
//    {
//        //记录开始位置
//        if (Input.GetMouseButtonDown(0)) {
//            startV = Input.mousePosition;
//        }

//        //抬起鼠标就开始画刀光
//        if (Input.GetMouseButtonUp(0)) {

//            #region 求刀光角度
//            endV = Input.mousePosition;
//            float angle = 90f;
//            if (startV.x!=endV.x) {
//                float angle1 = (endV.y - startV.y) / (endV.x - startV.x);
//                float angle2 = Mathf.Atan(angle1);
//                angle = angle2 * 180 / Mathf.PI;
//            }
//            #endregion

//            #region 创建刀光对象
//            GameObject obj = Instantiate(KnifePfb,endV,Quaternion.AngleAxis(angle,Vector3.forward))as GameObject;
//            obj.transform.parent = Caval.transform;
//            Destroy(obj,2f);
//            #endregion
//        }
        
//    }
//}
