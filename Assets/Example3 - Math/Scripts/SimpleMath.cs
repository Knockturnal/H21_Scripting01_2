using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimpleMath : MonoBehaviour
{
    void Start()
    {
		int a = 1;
		int b = 3;

		print("A starts as: " + a);

		print("B starts as: " + b);

		a = 2;

		print("A should be 2, and is: " + a);

		a = a + b;

		print("A + B is now: " + a);

		//This does the same as above
		a += b;

		print("Adding B again gives: " + a);

		a++;

		print("Incrementing a: " + a);
	}

}
