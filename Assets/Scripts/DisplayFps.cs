using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DisplayFps : MonoBehaviour {

    public Text text;
    public float fps;
    public float deltaTime;
	
	void Start ()
    {
        deltaTime = 0.0f;
		
	}
	

	void Update ()
    {
        fps = Mathf.FloorToInt(1.0f / deltaTime);
        text.text = fps.ToString();

        deltaTime += (Time.deltaTime - deltaTime) * 0.1f;

	}
}
