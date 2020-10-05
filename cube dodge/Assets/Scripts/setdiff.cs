using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
using System.IO;

public class setdiff : MonoBehaviour
{
    public void undoh(GameObject h){
	int o = PlayerPrefs.GetInt("o");
	if(o==1){
		PlayerPrefs.SetInt("diff", 30);
		PlayerPrefs.SetInt("diffmul", 5);
		PlayerPrefs.SetInt("o", 0);
		o = 0;
		h.GetComponent<Image>().sprite = Resources.Load<Sprite>("sprites/difficulty");
	}
	else{
		PlayerPrefs.SetInt("diff", 45);
		PlayerPrefs.SetInt("diffmul", 2);
		o = 1;
		PlayerPrefs.SetInt("o", 1);
		h.GetComponent<Image>().sprite = Resources.Load<Sprite>("sprites/nodifficulty");
	}
	

	
}}
