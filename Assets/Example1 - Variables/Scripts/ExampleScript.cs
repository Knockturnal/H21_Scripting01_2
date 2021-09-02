using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExampleScript : MonoBehaviour
{
	public int aWholeNumber = 5;

    // Start is called before the first frame update
    void Start()
    {
		aWholeNumber++;
		print(aWholeNumber);
    }

    // Update is called once per frame
    void Update()
	{
		int someValue = 5;
		print(someValue);
		someValue = 38;
	}
}
