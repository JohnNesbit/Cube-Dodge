using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class keeps : MonoBehaviour
{
	public string s;
    void Update()
    {
        if(PlayerPrefs.GetInt(s) == 1){
			
			GetComponent<Image>().sprite = Resources.Load<Sprite>("sprites/" + s);
		}
    }
}
