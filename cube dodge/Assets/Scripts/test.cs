using System.Collections.Generic;
using System.Collections;
using UnityEngine;
using System;
using System.IO;

public class test : MonoBehaviour
{
    
    public int interval;
    public AudioClip sound;
	public float[] coord;
	public AudioSource source;
    public Rigidbody rb;
    public GameObject rectangle;
    //public GameObject coin;
    public int i = 0;
	public float pitch = 1f;
    public int index;
    public int x = 0;
	public int numinit = 0;
	public int c = 0;
	public int curr_bloc = 0;
	public bool isa;
    //public int last_pos;
    public System.Random rnd = new System.Random();
    // Update is called once per frame
	void Start(){
		source.clip = sound;
		if(PlayerPrefs.GetInt("diff") != 45){
			coord[0] = 20f;
			coord[1] = 60f;
			coord[2] = 	80f;
			coord[3] = 	100f;
			numinit = 3;
		}
		else{
			coord[0] = 20f;
			coord[1] = 60f;
			coord[2] = 100f;
			numinit = 2;
			
		}
	}
    void Update()
    {
	interval = PlayerPrefs.GetInt("diff");
	isa = rb.position.z > coord[curr_bloc] && rb.position.z < coord[curr_bloc] + 3;
	
	if(PlayerPrefs.GetInt("strue") == 1){
	if(rb.position.z > 10){
		if(isa){
			source.pitch = pitch;
			pitch += .02f;
			source.Play(0);
			curr_bloc++;

		}
	}}
	if(rb.position.z < 10){
		source.Pause();
	}
	
	i++;
   	if(i>interval){
		 
		c++;
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
			if(rb.position.z + 130 < 1000){
				coord[c+numinit] = rb.position.z + 120;
				Instantiate (rectangle, new Vector3(x, 1, rb.position.z + 120), Quaternion.identity);  // Quaternion.identity transform.rotation
			}
	  		
	  	}
	
        }
    }
}