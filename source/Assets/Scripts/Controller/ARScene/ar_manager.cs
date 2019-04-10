using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class ARmanager : MonoBehaviour
{
    public static void Pause()
    {
        CameraDevice.Instance.Deinit();//将当前的摄像头禁用掉（反实例化），以便重新启用新的摄像头

    }
    public static void Cuntinue()
    {
        CameraDevice.Instance.Init(CameraDevice.CameraDirection.CAMERA_DEFAULT);//启用新的摄像头，实例化
    }
}
