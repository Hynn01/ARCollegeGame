using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class finalGradeShow: MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void onShow() {
        gameObject.SetActive(true);
    }

    public void onEnsure() {
        gameObject.SetActive(false);
        SceneManager.LoadScene("cuttingScene");
    }
}
