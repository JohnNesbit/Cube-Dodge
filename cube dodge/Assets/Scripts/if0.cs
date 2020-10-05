using UnityEngine;
using UnityEngine.SceneManagement;
using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;


public class if0 : MonoBehaviour
{
    public GameObject Canvas1;
    public GameObject Player;
    public GameObject MainCamera;
    public int ps;
    // Start is called before the first frame update
    void Update()
    {
	ps = PlayerPrefs.GetInt("past_score");
        if(ps != 0){
		Canvas1.SetActive(false);
		Player.GetComponent<playermovement>().enabled = true;
		Player.GetComponent<test>().enabled = true;
		Player.GetComponent<revenge>().enabled = false;
		MainCamera.GetComponent<follow_player>().enabled = true;
	}
    }
}
