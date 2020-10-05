using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ocolor : MonoBehaviour
{
    public GameObject o;
    public int level;
    public Material[] mymats;
    void Update()
    {
	level = PlayerPrefs.GetInt("level");
        while(level > 5){
		level -= 5;
		}
	Debug.Log(level);
	GetComponent<Renderer>().material = mymats[level-1];
    }
}
