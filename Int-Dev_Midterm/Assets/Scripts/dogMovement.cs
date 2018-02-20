using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dogMovement : MonoBehaviour {
	

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
	
	GetComponent<Rigidbody>().AddRelativeForce(0f,0f,.25f, ForceMode.VelocityChange);
		
	}
}
