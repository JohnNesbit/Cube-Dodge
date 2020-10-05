using UnityEngine;
using UnityEngine.SceneManagement;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine.UI;

public class LevelComplete : MonoBehaviour
{
    public Rigidbody rb;
    public Text score;
    public GameObject p;
    IEnumerator ExecuteAfterTime(float time){
	yield return new WaitForSeconds(time);	
	SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
    public void LoadNextLevel()
    {
	p.GetComponent<playermovement>().enabled = false;
	PlayerPrefs.SetInt("level", PlayerPrefs.GetInt("level") + 1);
	PlayerPrefs.SetInt("past_score", Convert.ToInt32(score.text));
	StartCoroutine(ExecuteAfterTime(2f));
	p.GetComponent<playermovement>().enabled = true;
	
    }
}


