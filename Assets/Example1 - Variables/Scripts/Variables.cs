using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Variables : MonoBehaviour
{
	//	Variables declared outside functions are called "global" variables
	private bool globalBool = false;
	private int someInteger = 67;
	private string someText = "Hello World!";
	private float someDecimalNumber = 7.62f;

	//	All public fields (variables) can be seen from the inpsector
	//	Public fields can also be set in this script from other scripts
	public int canBeSetFromAnotherClass;

	//	A private variable with the [SerializeField] tag can be set from the inspector
	//	But it can NOT be read or set from other scripts
	[SerializeField] private int canBeSetInInspector;

	private void Start()
	{
		//	A variable declared in a function is called "local"
		//	Local variables don't have an accessor (public/private)
		//	This is because they can only be used within the function they're declared
		bool localBool = true;
	}

	private void Update()
	{
		//	Here, the variable localBool doesn't exist, because it isn't defined in this scope
		//	This can be seen by uncommenting the following line:
		//localBool = false;

		Debug.Log(canBeSetInInspector);
	}
}
