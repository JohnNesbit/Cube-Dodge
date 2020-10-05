using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class revenge : MonoBehaviour
{
    public float sidewaysForce = 15f;
    public Rigidbody rb;
    void Update()
    {
	
        if(rb.position.x > 2){
		sidewaysForce = -50f;
	}
	if(rb.position.x < -1){
		sidewaysForce = 50f;
	}
	rb.AddForce(sidewaysForce *  Time.deltaTime, 0, 0, ForceMode.VelocityChange);

    }
}
