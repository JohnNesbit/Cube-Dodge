using UnityEngine;
using UnityEngine.UI;
using System;
using System.Collections;
using System.IO;

public class Score : MonoBehaviour
{
    public Transform player;
    public Text scoreText;
    public int past_score;
    public int high_score;
    public int multiplier;
    public int score;
	// Update is called once per frame
    void Start(){
	past_score = PlayerPrefs.GetInt("past_score");
    }
    void Update()
    {
	multiplier = PlayerPrefs.GetInt("level");
	if(multiplier == 0){
		PlayerPrefs.SetInt("level", 1);
		multiplier = PlayerPrefs.GetInt("level");
	}
	if(PlayerPrefs.GetInt("diffmul") == 0){
		PlayerPrefs.SetInt("diffmul", 1);
		PlayerPrefs.SetInt("diff", 50);
	}
	score = past_score + ((Convert.ToInt32(player.position.z/3) * multiplier) * PlayerPrefs.GetInt("diffmul"));
        scoreText.text = score.ToString("0");
	high_score = PlayerPrefs.GetInt("high_score");
	if(score > high_score){
		PlayerPrefs.SetInt("high_score", score);
	}
    }
}
