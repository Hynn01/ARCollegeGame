using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class vegDance : MonoBehaviour
{
    Vector3 pos;
    //Renderer rd;

    void Start()
    {
        Button btn = this.GetComponent<Button>();
        btn.onClick.AddListener(OnClick);
        pos = this.transform.localPosition;
        //rd = this.GetComponent<SpriteRenderer>();
        //Debug.Log("000");

    }

    void OnClick()
    {
        //Debug.Log("111");

        //this.transform.position += new Vector3(0 + 5 * Mathf.Cos(Time.deltaTime * 3.14f / 180), 0 + 5 * Mathf.Sin(Time.deltaTime * 3.14f / 180), 0);
        //this.transform.RotateAround(Vector3.zero, Vector3.up, 20 * Time.deltaTime);
        //while (Time.deltaTime<360)
        //{
        //    //this.transform.position += new Vector3(0 + 5 * Mathf.Cos(Time.deltaTime * 3.14f / 180), 0 + 5 * Mathf.Sin(Time.deltaTime * 3.14f / 180), 0);
        //    Debug.Log("222");
        //}

        //Debug.Log("333");

        ////让菜回到它原来的位置
        //this.transform.position = pos;

        ////让菜变暗
        this.GetComponent<CanvasGroup>().alpha = 0.3f;
    }
}