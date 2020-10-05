// makes player active

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class setactive : MonoBehaviour
{
    public void start(GameObject objtd){
	objtd.GetComponent<playermovement>().enabled = true;
	objtd.GetComponent<test>().enabled = true;
	objtd.GetComponent<revenge>().enabled = false;
    }
}
