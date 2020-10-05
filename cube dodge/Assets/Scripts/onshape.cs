using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class onshape : MonoBehaviour
{
	public void on_press(string s){
		PlayerPrefs.SetInt("square", 1);
		Sprite sp = Resources.Load<Sprite>("sprites/" + s);
		
		if(PlayerPrefs.GetInt(s) == 1){
			PlayerPrefs.SetString("shape", s);

		}
		else if(PlayerPrefs.GetInt("coins") > 5000){
			PlayerPrefs.SetString("shape", s);
			PlayerPrefs.SetInt("coins", PlayerPrefs.GetInt("coins") - 5000);
			PlayerPrefs.SetInt(s, 1);
			GetComponent<Image>().sprite = sp;
		}
	}
}
