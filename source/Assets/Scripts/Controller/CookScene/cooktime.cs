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
    public Button addSalt;
    public Button addSugar;
    public Button addAginomoto;
    public Button addOil;
    public Button addSoy;
    public GameObject parent;
    int i = 0;
    int j = 0;
    float speed = 40;
    private float totalTime = 0;
    private float intervalTime = 1;
    private GameObject salt;
    private GameObject sugar;
    private GameObject aginomoto;
    private int saltNumber,sugarNumber,aginomotoNumber,oilNumber,soyNumber;
    private Color s;
    // Use this for initialization
    void Start()
    {
        //Debug.Log("我的天");
        btn.onClick.AddListener(OnClick);
        slic.onClick.AddListener(OnClickSlic);
        addSalt.onClick.AddListener(OnClickSalt);
        addSugar.onClick.AddListener(OnClickSugar);
        addOil.onClick.AddListener(OnClickOil);
        addSoy.onClick.AddListener(OnClickSoy);
        addAginomoto.onClick.AddListener(OnClickAginomoto);
        int count = transform.parent.childCount - 1;//Panel移位
        CountDownText.transform.SetSiblingIndex(count);//Panel移位
        CountDownText.text = string.Format("{0:D2} : {1:D2}", (int)totalTime / 60, (int)totalTime % 60);
    }
    private void OnClickSlic()
    {
        j = j + 1;
        float step = speed * Time.deltaTime;
        Quaternion targetAngels;
        int childCount =  parent.transform.childCount;
        for (int i = 0; i < childCount; i++)
        {
            Destroy(parent.transform.GetChild(i).gameObject);
        }


        if (j % 2 == 1)
        {

            // targetAngels = Quaternion.Euler(24f, 0, 0);
            //slic.transform.rotation = Quaternion.Slerp(slic.transform.rotation, targetAngels, step);
            slic.transform.Rotate(new Vector3(0, 0, -1) * 10);
            this.changeSpriteByImage("food2");
        }
        else
        {
            //targetAngels = Quaternion.Euler(-24f, 0, 0);
            //slic.transform.rotation = Quaternion.Slerp(slic.transform.rotation, targetAngels, step);
            slic.transform.Rotate(new Vector3(0,0,1) * 10);
            this.changeSpriteByImage("food1");
        }

    }

    //加盐
    private void OnClickSalt()
    {
        saltNumber++;
        GameObject itemPrefab = Resources.Load<GameObject>("Prefabs/salt");
        salt = GameObject.Instantiate(itemPrefab, parent.transform, true);//分配父类的时候是否保持原始的世界位置，false不保留，true保留
    }

    //加糖
    private void OnClickSugar()
    {
        sugarNumber++;
        GameObject itemPrefab = Resources.Load<GameObject>("Prefabs/sugar");
        sugar = GameObject.Instantiate(itemPrefab, parent.transform, true);//分配父类的时候是否保持原始的世界位置，false不保留，true保留
    }
    //加味精
    private void OnClickAginomoto()
    {
        aginomotoNumber++;
        GameObject itemPrefab = Resources.Load<GameObject>("Prefabs/aginomoto");
        aginomoto = GameObject.Instantiate(itemPrefab, parent.transform, true);//分配父类的时候是否保持原始的世界位置，false不保留，true保留

    }
    //加油
    private void OnClickOil()
    {
        oilNumber++;
        GameObject itemPrefab = Resources.Load<GameObject>("Prefabs/oil");
        aginomoto = GameObject.Instantiate(itemPrefab, parent.transform, true);//分配父类的时候是否保持原始的世界位置，false不保留，true保留

    }
    //加酱油
    private void OnClickSoy()
    {
        soyNumber++;
        GameObject itemPrefab = Resources.Load<GameObject>("Prefabs/soy");
        aginomoto = GameObject.Instantiate(itemPrefab, parent.transform, true);//分配父类的时候是否保持原始的世界位置，false不保留，true保留
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
            
            Sprite spriteB = Resources.Load<Sprite>("Cooked/switch_turned");
            btn.GetComponent<SpriteRenderer>().sprite = spriteB;
            StartCoroutine(CountDown());
        }
        else
        {
            Sprite spriteB = Resources.Load<Sprite>("Cooked/switch");
            btn.GetComponent<SpriteRenderer>().sprite = spriteB;
            StopCoroutine(CountDown());
        }
      
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
