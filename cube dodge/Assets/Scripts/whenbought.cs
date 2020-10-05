using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class whenbought : MonoBehaviour
{
    public void CHANGEC(GameObject b){
	Sprite s = Resources.Load<Sprite>("sprites/base");
	Color c = b.GetComponent<Image>().color;
	Debug.Log(c);
	
	if(PlayerPrefs.GetInt(b.name) == 1){
	    PlayerPrefs.SetFloat("r", c.r);
	    PlayerPrefs.SetFloat("g", c.g);
	    PlayerPrefs.SetFloat("b", c.b);

	}
	else if(PlayerPrefs.GetInt("coins") > 5000){
	    PlayerPrefs.SetFloat("r", c.r);
	    PlayerPrefs.SetFloat("g", c.g);
	    PlayerPrefs.SetFloat("b", c.b);
	    PlayerPrefs.SetInt("coins", PlayerPrefs.GetInt("coins") - 5000);
	    PlayerPrefs.SetInt(b.name, 1);
	    b.GetComponent<Image>().sprite = s;
	}
    }
}
