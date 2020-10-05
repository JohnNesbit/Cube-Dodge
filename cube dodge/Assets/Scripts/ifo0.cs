using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ifo0 : MonoBehaviour
{
	public string ostr;
	public string paths;
	public GameObject h;
    void Start()
    {
        if(PlayerPrefs.GetInt(ostr)==1){
			h.GetComponent<Image>().sprite = Resources.Load<Sprite>("sprites/" + paths);
		}
    }
}
