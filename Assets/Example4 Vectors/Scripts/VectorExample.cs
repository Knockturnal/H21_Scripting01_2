using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VectorExample : MonoBehaviour
{
	public Vector3 movement;

    void Update()
    {
		//	We add the movement Vector each frame, but divide by 10
		//	so we have finer control over the speed

		//	Every GameObject has a Transform component, which is why we don't need a reference
		//	We can simply write "transform" to access it
		transform.position += movement / 10f;
	}
}
