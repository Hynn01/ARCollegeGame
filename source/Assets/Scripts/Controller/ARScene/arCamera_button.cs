using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using Vuforia;

public class arCamera_button : MonoBehaviour
{
    public ARmanager aRmanager;
    void Start()
    {
        //ARmanager.Cuntinue();
        Button btn = this.GetComponent<Button>();
        btn.onClick.AddListener(OnClick);
    }

    private void OnClick()
    {
        //ARmanager.Pause();
        SceneManager.LoadScene("mainScene");
    }
}