using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class changeshape : MonoBehaviour
{
	
	public GameObject Player;
	public int s;
	public float r;
	public float g; 
	public float b;
    public void Update()
    {
		r = PlayerPrefs.GetFloat("r");
		g = PlayerPrefs.GetFloat("g"); 
		b = PlayerPrefs.GetFloat("b");
		string shape = PlayerPrefs.GetString("shape");
		if(shape == ""){
			shape = "square";
		}
		
        Mesh m = Resources.Load<Mesh>(shape);
		Player.GetComponent<MeshFilter>().mesh = m;
		if (shape == "cross"){
			Player.GetComponent<MeshRenderer>().materials = new Material[2];
			Player.GetComponent<MeshRenderer>().materials[0] = Resources.Load<Material>("playermatt");
			Player.GetComponent<MeshRenderer>().materials[1] = Resources.Load<Material>("playermatt");
			Player.GetComponent<MeshRenderer>().materials[0].SetColor("_Color", new Color(r, g, b));
			Player.GetComponent<MeshRenderer>().materials[1].SetColor("_Color", new Color(r, g, b));
			Player.GetComponent<BoxCollider>().size = new Vector3(1f,1.4f,1f);
			Player.GetComponent<BoxCollider>().center = new Vector3(0f,0f,0f);
		}
		if(shape == "square"){
			Player.GetComponent<MeshRenderer>().materials = new Material[1];
			Player.GetComponent<MeshRenderer>().materials[0] = Resources.Load<Material>("playermatt");
			Player.GetComponent<MeshRenderer>().materials[0].SetColor("_Color", new Color(r, g, b));
			Player.GetComponent<BoxCollider>().size = new Vector3(1,1,1);
			Player.GetComponent<BoxCollider>().center = new Vector3(0f,0f,0f);
		}
		if(shape == "sphere"){
			Player.GetComponent<MeshRenderer>().materials = new Material[1];
			Player.GetComponent<MeshRenderer>().materials[0] = Resources.Load<Material>("playermatt");
			Player.GetComponent<MeshRenderer>().materials[0].SetColor("_Color", new Color(r, g, b));
			Player.GetComponent<BoxCollider>().size = new Vector3(1f,1.2f,1f);
			Player.GetComponent<BoxCollider>().center = new Vector3(0f,0f,0f);
		}
		if (shape == "cyl"){
			Player.GetComponent<MeshRenderer>().materials = new Material[2];
			Player.GetComponent<MeshRenderer>().materials[0] = Resources.Load<Material>("playermatt");
			Player.GetComponent<MeshRenderer>().materials[0].SetColor("_Color", new Color(r, g, b));
			Player.GetComponent<BoxCollider>().size = new Vector3(1f,1.5f,1f);
			Player.GetComponent<BoxCollider>().center = new Vector3(0f,0f,0f);
		}
		if (shape == "cone"){
			Player.GetComponent<MeshRenderer>().materials = new Material[2];
			Player.GetComponent<MeshRenderer>().materials[0] = Resources.Load<Material>("playermatt");
			Player.GetComponent<MeshRenderer>().materials[0].SetColor("_Color", new Color(r, g, b));
			Player.GetComponent<BoxCollider>().size = new Vector3(1.24f,1.3f,1.2f);
			Player.GetComponent<BoxCollider>().center = new Vector3(0.13f,0.35f,-0.02f);
		}
		if (shape == "heart"){
			Player.GetComponent<MeshRenderer>().materials = new Material[2];
			Player.GetComponent<MeshRenderer>().materials[0] = Resources.Load<Material>("playermatt");
			Player.GetComponent<MeshRenderer>().materials[0].SetColor("_Color", new Color(r, g, b));
			Player.GetComponent<BoxCollider>().size = new Vector3(1f,1f,.8f);
			Player.GetComponent<BoxCollider>().center = new Vector3(0f,0f,0f);
		}
		if (shape == "star"){
			Player.GetComponent<MeshRenderer>().materials = new Material[2];
			Player.GetComponent<MeshRenderer>().materials[0] = Resources.Load<Material>("playermatt");
			Player.GetComponent<MeshRenderer>().materials[0].SetColor("_Color", new Color(r, g, b));
			Player.GetComponent<BoxCollider>().size = new Vector3(1f,1f,.8f);
			Player.GetComponent<BoxCollider>().center = new Vector3(0f,0.01f,0f);
		}
		if (shape == "trishit"){ // fucking kil me
			Player.GetComponent<MeshRenderer>().materials = new Material[2];
			Player.GetComponent<MeshRenderer>().materials[0] = Resources.Load<Material>("playermatt");
			Player.GetComponent<MeshRenderer>().materials[0].SetColor("_Color", new Color(r, g, b));
			Player.GetComponent<BoxCollider>().size = new Vector3(1f,1f,1f);
			Player.GetComponent<BoxCollider>().center = new Vector3(0f,0f,0f);
		}
		
		
    }
}
