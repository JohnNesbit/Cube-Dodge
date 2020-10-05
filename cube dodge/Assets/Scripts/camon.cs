// makes cam active

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camon : MonoBehaviour
{
    public void start(GameObject objtd){
	objtd.GetComponent<follow_player>().enabled = true;
    }
}
