using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.IO;

public class initb : MonoBehaviour
{
    public Rigidbody rb;
    public GameObject rectangle;
    //public GameObject coin;
    public int i = 0;
    public int index;
    public int x = 0;
    //public int last_pos;
    public System.Random rnd = new System.Random();
    public void init_blocks(float y){
		List<int> intlist = new List<int>()
        	{-6,-5,-4,-3,-2,-1, 0, 1,2,3,4,5,6};
		//Instantiate (coin, new Vector3(x, 1, rb.position.z + 110), Quaternion.identity);  // Quaternion.identity transform.rotation
		i = 0; 
		int prs = rnd.Next(3, 5); // how many squares

		while(prs > 0){
			if(intlist.Count < 2){
				break;
			}
			index = rnd.Next(intlist.Count);
	  		x = intlist[index]; // bug
	  		intlist.Remove(x);
			if(x<6 && intlist.IndexOf(x+1) != -1){ 
				intlist.Remove(x+1);
			}
			if(x<5 && intlist.IndexOf(x+2) != -1){
				intlist.Remove(x+2);
			}
			if(x>-6 && intlist.IndexOf(x-1) != -1){
				intlist.Remove(x-1);
			}
	
			if(x>-5 && intlist.IndexOf(x-2) != -1){
				intlist.Remove(x-2);
			}
			prs--;
	  		Instantiate (rectangle, new Vector3(x, 1, y), Quaternion.identity);  // Quaternion.identity transform.rotation
			}
    			}
    // Start is called before the first frame update
    void Start()
    {	
		if(PlayerPrefs.GetInt("diff") != 45){
			init_blocks(20f);
			init_blocks(60f);
			init_blocks(80f);
			init_blocks(100f);
			
		}
		else {
			
		init_blocks(20f);
		init_blocks(60f);
		init_blocks(100f);
		}
	}
}
