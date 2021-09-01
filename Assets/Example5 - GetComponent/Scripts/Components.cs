using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Components : MonoBehaviour
{
	public Rigidbody myRigidBody;			//	We set the value of this one in the inspector
	private MeshRenderer myMeshRenderer;	//	This one is private, so we have to set it in code

    void Start()
    {
		//	GetComponent can be used instead of public fields,
		//	but starting out I reccommend public fields instead
		myMeshRenderer = GetComponent<MeshRenderer>();


		//	Do something to the components for effect
		myRigidBody.AddForce(Vector3.up * 500f);
		myMeshRenderer.material.color = Color.blue;
    }

}
