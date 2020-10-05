using UnityEngine;
using System;
using System.IO;
using UnityEngine.UI;

public class playercollision : MonoBehaviour
{

    public playermovement movement;
    public Transform player;
    public int curr_int;
    public Text coinsd;
    void OnCollisionEnter(Collision collisionInfo)
    {
        if(collisionInfo.collider.tag == "Obstacle")
        {
	    curr_int = PlayerPrefs.GetInt("past_score") + (Convert.ToInt32(player.position.z/3) * PlayerPrefs.GetInt("level"));
            movement.enabled = false;
            FindObjectOfType<GameManager>().EndGame();
	    int filetext = PlayerPrefs.GetInt("coins");
	    int to_write = curr_int/10 * PlayerPrefs.GetInt("diffmul");
	    PlayerPrefs.SetInt("coins", to_write + filetext);
	    //coinsd.SetActive(true);
	    coinsd.text = "+ " + to_write.ToString();
        }
    }
}
