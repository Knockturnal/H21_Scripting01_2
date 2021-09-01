using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputExample : MonoBehaviour
{
	public Rigidbody myRigidbody;
	public float moveSpeed;

	private void Update()
	{
		if (Input.GetKey(KeyCode.W))
		{
			myRigidbody.velocity += Vector3.forward * moveSpeed;
		} 
		else if (Input.GetKey(KeyCode.S))
		{
			myRigidbody.velocity -= Vector3.forward * moveSpeed;
		}

		if (Input.GetKey(KeyCode.A))
		{
			myRigidbody.velocity += Vector3.left * moveSpeed;
		}
		else if (Input.GetKey(KeyCode.D))
		{
			myRigidbody.velocity -= Vector3.left * moveSpeed;
		}

	}
}
