using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class skyc : MonoBehaviour
{
	public Material[] mats;
	public int level;
    void Update()
    {
		level = PlayerPrefs.GetInt("level");
        while(level > 5){
		level -= 5;
		}
		RenderSettings.skybox = mats[level-1];
    }
}
