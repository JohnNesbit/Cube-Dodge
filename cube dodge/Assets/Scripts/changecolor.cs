using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class changecolor : MonoBehaviour
{
    
    public float r;
    public float g;
    public float b;
    void Update()
    {
    r = PlayerPrefs.GetFloat("r");
	g = PlayerPrefs.GetFloat("g"); 
	b = PlayerPrefs.GetFloat("b");
	for(int i = 0; i < GetComponent<Renderer>().materials.Length; i++) {
     GetComponent<Renderer>().materials[i].SetColor("_Color", new Color(r, g, b));
	}
	
    }
}
