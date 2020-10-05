using UnityEngine;
using UnityEngine.UI;
using System;
using System.Collections;
using System.IO;

public class leveldis : MonoBehaviour
{

    public Text scoreText;
    void Update()
    {
	
        scoreText.text = "LEVEL " + PlayerPrefs.GetInt("level");
	
    }
}
