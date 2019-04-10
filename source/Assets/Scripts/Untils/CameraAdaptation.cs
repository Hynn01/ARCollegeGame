using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraAdaptation : MonoBehaviour {
    float orthographicsize = 6.6f;
    float initial_aspect_Radio = 1.77f;
    float screenHeight;
    float screenWidth;
    float fact_aspect_Radio;
	// Use this for initialization
	void Start () {
        screenHeight = Screen.height;
        screenWidth = Screen.width;
        fact_aspect_Radio = screenWidth / screenHeight;
        gameObject.GetComponent<Camera>().orthographicSize =
            (orthographicsize * initial_aspect_Radio) / fact_aspect_Radio;
	}
}
