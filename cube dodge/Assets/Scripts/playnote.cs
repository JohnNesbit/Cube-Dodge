using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playnote : MonoBehaviour
{
	public int i = 0;
	public Rigidbody rb;
	public AudioClip sound;
	public AudioSource source;
	public int interval;
	public List<float> coordar = new List<float>();
	void Start(){
		source.clip = sound;
		
	}
    void Update()
    {
		if(coordar.IndexOf(rb.position.z) != -1){
			source.Play(0);
		}
		interval = PlayerPrefs.GetInt("diff");
		i++;
		if(i>interval){
			if(rb.position.z + 130 < 500){
				coordar.Add(rb.position.z + 120);
			}
		
		}
    }
}
