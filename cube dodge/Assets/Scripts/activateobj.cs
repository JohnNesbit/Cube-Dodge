using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class activateobj : MonoBehaviour
{
    public void start_any(GameObject objtd){
	objtd.SetActive(!objtd.activeSelf);
    }
}

