using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMovement : MonoBehaviour
{
	private float tug;
	private float rotateSpeed;

// Use this for initialization
	void Start ()
	{

		tug = 2f;
		rotateSpeed = 2f;

	}
	
	// Update is called once per frame
	void Update () {
		
		// TUG INPUT

		if (Input.GetKeyDown(KeyCode.W))
		{
			GetComponent<Rigidbody>().AddRelativeForce(0f,0f,tug, ForceMode.Impulse);
		}

		if (Input.GetKeyDown(KeyCode.S))
		{
			GetComponent<Rigidbody>().AddRelativeForce(0f,0f,-tug, ForceMode.Impulse);
		}

		if (Input.GetKeyDown(KeyCode.A))
		{
			GetComponent<Rigidbody>().AddRelativeForce(-tug,0f,0f, ForceMode.Impulse);
		}

		if (Input.GetKeyDown(KeyCode.D))
		{
			GetComponent<Rigidbody>().AddRelativeForce(tug,0f,0f, ForceMode.Impulse);
		}
		
		// LOOK INPUT

		if (Input.GetKey(KeyCode.LeftArrow))
		{
			GetComponent<Transform>().eulerAngles += new Vector3(0f, -rotateSpeed, 0f);
		}

		if (Input.GetKey(KeyCode.RightArrow))
		{
			GetComponent<Transform>().eulerAngles += new Vector3(0f, rotateSpeed, 0f);
		}
		
		// LEASH

		GetComponent<LineRenderer>().SetPosition(0, new Vector3(GetComponent<Transform>().position.x,
																GetComponent<Transform>().position.y,
																GetComponent<Transform>().position.z));
		GetComponent<LineRenderer>().SetPosition(1, new Vector3(GameObject.Find("Dog").GetComponent<Transform>().position.x,
																GameObject.Find("Dog").GetComponent<Transform>().position.y,
																GameObject.Find("Dog").GetComponent<Transform>().position.z));
	}
}
