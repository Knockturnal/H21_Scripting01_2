using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Conditionals : MonoBehaviour
{
	public bool sayHello = false;
	//	When declaring multiple variables of the same access and type (public int in this case) you can do it like this
	public int firstNumber, secondNumber;
	void Start()
	{
		//	Two equals signs means comparison
		if (sayHello == true)
		{
			print("Hello World!");
		}

		if (sayHello == false)
		{
			print("Goodbye World!");
		}



		//	! means not, so != means not equal
		if (firstNumber != secondNumber)
		{
			print("The first and second numbers differ");
		}
		else
		{
			print("The first and second numbers are equal!");
		}

		

		if(firstNumber > secondNumber)
		{
			print("The first number is higher!");
		}

		if(secondNumber >= firstNumber)
		{
			print("The second number is higher or equal to the first!");
		}



		//We declare a local bool
		bool sayHowAreYou = true;

		//	The AND operator is written as &&
		if (sayHello == true && sayHowAreYou == true)
		{
			print("How are you? I wouldn't ask if I didn't first say hello");
		}

		//	The OR operator is written as ||
		if (sayHello == false || sayHowAreYou == false)
		{
			print("Either, we're not saying hello, or we're not asking how you are...");
		}

		

		//		BONUS:

		//		SHORTCUTS when working with BOOLS


		//	We can omit the == true part to create a shorthand
		if (sayHello)
		{
			print("This also works!");
		}

		//	Because ! means not, the shorthand becomes !bool
		if (!sayHello)
		{
			print("Again, this works too!");
		}


		//		IF STATEMENT shortcut

		//	When we only have a single line of code after an if statement
		//	we can ignore the curly brackets { }
		if (sayHello)
			print("Now we're writing less long-winded code!");

		//		SWITCH STATEMENT
		//	A short way to evaluate a lot of different states for a single variable
		//	Can be used in place of a big list of "if() else() else() else() else()"
		//	Only used with INT or more commonly ENUM types

		switch (firstNumber)
		{
			case 0:
				print("FirstNumber was 0");
				break;
			case 1:
				print("FirstNumber was 1");
				break;
			default:
				print("FirstNumber was something else");
				break;
		}
	}

}
