using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.UI;
using System.IO;

public class display_h_s : MonoBehaviour
{
    public Text scoreText;
    void Start()
    {
        scoreText.text = Environment.NewLine + Environment.NewLine + Environment.NewLine + Environment.NewLine + PlayerPrefs.GetInt("high_score");
    }
}
