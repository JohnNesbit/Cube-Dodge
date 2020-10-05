using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class soundb : MonoBehaviour
{
	public void on_press(GameObject h){
		int so = PlayerPrefs.GetInt("so");
		if(so==1){
		PlayerPrefs.SetInt("strue", 1);
		PlayerPrefs.SetInt("so", 0);
		so = 0;
		h.GetComponent<Image>().sprite = Resources.Load<Sprite>("sprites/soundic");
	}
	else{
		PlayerPrefs.SetInt("strue", 0);
		so = 1;
		PlayerPrefs.SetInt("so", 1);
		h.GetComponent<Image>().sprite = Resources.Load<Sprite>("sprites/nosoundic");
	}
		
	}
}
