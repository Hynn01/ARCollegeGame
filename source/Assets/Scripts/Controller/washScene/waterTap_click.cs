using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class waterTap_click : MonoBehaviour
{
    public GameObject waterDrop; 
    // Start is called before the first frame update
    void Start()
    {
        Button btn = this.GetComponent<Button>();
        btn.onClick.AddListener(OnClick);
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnClick()
    {
        //if (waterDrop.GetComponent<Renderer>().enabled == false)
        //{
        //    waterDrop.GetComponent<Renderer>().enabled = true;
        //}
        //else {
        //    waterDrop.GetComponent<Renderer>().enabled = false;
        //}

        if (waterDrop.GetComponent<CanvasGroup>().alpha == 0)
        {
            waterDrop.GetComponent<CanvasGroup>().alpha = 1;
        }
        else {
            waterDrop.GetComponent<CanvasGroup>().alpha =0;
        }
       ;


    }
}