﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ar_click : MonoBehaviour
{
    void Start()
    {
        Button btn = this.GetComponent<Button>();
        btn.onClick.AddListener(OnClick);
    }

    private void OnClick()
    {
        SceneManager.LoadScene("arCamrea");
    }
}
