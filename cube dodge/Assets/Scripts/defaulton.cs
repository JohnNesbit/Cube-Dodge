using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class defaulton : MonoBehaviour
{
	public GameObject b;
    // Start is called before the first frame update
    void Start()
    {
        PlayerPrefs.SetInt(b.name, 1);
    }
}
