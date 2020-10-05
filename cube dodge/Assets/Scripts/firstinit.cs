using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class firstinit : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
		
        if(PlayerPrefs.GetInt("hk30") != 14){
			PlayerPrefs.SetFloat("level", 1);
			PlayerPrefs.SetFloat("r", 1);
			PlayerPrefs.SetFloat("g", 1);
			PlayerPrefs.SetFloat("b", 1);
			PlayerPrefs.SetInt("diff", 40);
			PlayerPrefs.SetInt("diffmul", 2);
			PlayerPrefs.SetInt("o", 1);
			
		}
		PlayerPrefs.SetInt("hk30", 14);
    }
}
