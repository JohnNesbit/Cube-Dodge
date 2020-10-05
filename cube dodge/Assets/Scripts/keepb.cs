using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class keepb : MonoBehaviour
{
    public GameObject b;
    void Update()
    {
        if(PlayerPrefs.GetInt(b.name) == 1){
	    b.GetComponent<Image>().sprite = Resources.Load<Sprite>("sprites/base");
		

	}
    }
}
