using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;



public class cooktime : MonoBehaviour
{

    public Text CountDownText;
    public Button btn;
    public GameObject image1;
    public Button slic;
    int i = 0;
    int j = 0;
    float speed = 40;
    private float totalTime = 0;
    private float intervalTime = 1;
    private Color s;
    // Use this for initialization
    void Start()
    {
        Debug.Log("我的天");
        btn.onClick.AddListener(OnClick);
        slic.onClick.AddListener(OnClickSlic);
        int count = transform.parent.childCount - 1;//Panel移位
        CountDownText.transform.SetSiblingIndex(count);//Panel移位
        CountDownText.text = string.Format("{0:D2} : {1:D2}", (int)totalTime / 60, (int)totalTime % 60);
    }
    private void OnClickSlic()
    {
        j = j + 1;
        float step = speed * Time.deltaTime;
        Quaternion targetAngels;
        if (j % 2 == 1)
        {

            targetAngels = Quaternion.Euler(24f, -9f, 48f);
            slic.transform.rotation = Quaternion.Slerp(slic.transform.rotation, targetAngels, step);
            this.changeSpriteByImage("food2");
        }
        else
        {
            targetAngels = Quaternion.Euler(-24f, 9f, -48f);
            slic.transform.rotation = Quaternion.Slerp(slic.transform.rotation, targetAngels, step);
            this.changeSpriteByImage("food1");
        }

    }
    //改变食物的图片
    void changeSpriteByImage(string foodName)
    {
        string foodPath = "Cooked/" + foodName;
        //GameObject itemPrefab = Resources.Load<GameObject>("Prefabs/FoodImage");
        Sprite spriteB = Resources.Load<Sprite>(foodPath);
        //spriteB = Resources.Load<Sprite>("egg");
        Debug.Log(Resources.Load<Sprite>(foodPath));
        image1.GetComponent<SpriteRenderer>().sprite = spriteB;
        //image1.GetComponent<SpriteRenderer>().color = s;
        Debug.Log("123");
    }
    private void OnClick()
    {
        i = i + 3;
        float step = speed * Time.deltaTime;
        Debug.Log("jhdskjdfh");
        Quaternion targetAngels;

        if (i % 2 == 1)
        {
            targetAngels = Quaternion.Euler(24f, -9f, 48f);
            btn.transform.rotation = Quaternion.Slerp(btn.transform.rotation, targetAngels, step);
            StartCoroutine(CountDown());
        }
        else
        {
            targetAngels = Quaternion.Euler(-24f, 9f, -48f);
            btn.transform.rotation = Quaternion.Slerp(btn.transform.rotation, targetAngels, step);
            StopCoroutine(CountDown());
        }
        //this.transform.Rotate(Vector3.forward * speed);
    }

    private IEnumerator CountDown()
    {
        while (i % 2 == 1)
        {
            yield return new WaitForSeconds(1);
            totalTime++;
            CountDownText.text = string.Format("{0:D2} : {1:D2}", (int)totalTime / 60, (int)totalTime % 60);

            //material.SetVector("_Color",new Vector4(1,1,1,1));
            if (totalTime <= 20)
            {
                float x = 255 - (totalTime) * 4;
                float y = 255 - (totalTime) * 8;
                float z = 255 - (totalTime) * 4;
                s = new Color(y / 255, x / 255, z / 255, 1);
                image1.GetComponent<SpriteRenderer>().color = s;
            }


        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
