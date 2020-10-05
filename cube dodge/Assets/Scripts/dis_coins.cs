using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class dis_coins : MonoBehaviour
{
    public Text t;
    void Update()
    {
     t.text = PlayerPrefs.GetInt("coins").ToString();
    }
}
