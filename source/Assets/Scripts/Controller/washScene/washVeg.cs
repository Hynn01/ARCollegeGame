using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class washVeg : MonoBehaviour
{
    public GameObject[] vegs;

    // Start is called before the first frame update
    void Start()
    {

        float y = -5.75f;
        float x = Random.Range(-6.5f, 6.5f); //随机蔬菜出现的x坐标
        for(int i=0;i < vegs.Length; i++) {
            GameObject veg = Instantiate(vegs[i]) as GameObject;
            veg.transform.position = new Vector3(x, y, 0);
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
