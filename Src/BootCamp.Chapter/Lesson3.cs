using System;
using System.Collections.Generic;
using System.Text;

namespace BootCamp.Chapter
{
    public class Lesson3
    {
		public static void Demo()
		{
			/*2) Take homework 2 code, place it in the forked branch and refactor it using functions.There should be as little duplicate code as possible (there should be functions for:
				-Calculating BMI(weight comes in kg, height comes in meters),
			-Prompt for input and converting it to int(print message for request, read console input and return converted input to int), 
			-Prompt for input and converting it to string(print message for request, read console input and return input),
			-Prompt for input and converting it to float(print message for request, read console input and return converted input to float).
			3) Put all the function you made into the right places in Checks.cs class. Run tests, make sure you pass all the tests
			4) Put all program.cs logic to Lesson3.cs.Call it from main function. Program class should look like this:
			*/

			string quit = "";

			while (quit != "q" && quit != "Q")
			{
				int age = getUserInt("age");
				string firstName = getUserString("first");
				string lastNmae = getUserString("last");
				float weight = getUserFloat("weight(Kg)");
				float height = getUserFloat("height(cm)");


				Console.WriteLine($"{firstName} {lastNmae} is {age} years old, his weight is {weight} kg and his height is {height} cm.");

				var BMI = calculateBMI(weight, height);

				Console.WriteLine($"{firstName} {lastNmae}'s BMI is: {BMI}.");

				Console.WriteLine("Enter \"q\" to quit or press any other key to continue ");
				quit = Console.ReadLine();
			}

		}

		public static float calculateBMI(float weight, float height)
		{
			float heightInMeters = height / 100f;
			return (weight / (heightInMeters * heightInMeters));

		}

		public static string getUserString(string requestedInfo)
		{
			string response;
			Console.WriteLine($"please input {requestedInfo}: ");
			return response = Console.ReadLine().Trim();

		}


		public static float getUserFloat(string requestedInfo)
		{
			string response;
			Console.WriteLine($"please input {requestedInfo}: ");
			response = Console.ReadLine().Trim();

			float number;

			while (!float.TryParse(response, out number))
			{
				Console.WriteLine($"Please enter {requestedInfo} as a whole number: ");
				response = Console.ReadLine().Trim();
			}

			return number;

		}



		public static int getUserInt(string requestedInfo)
		{
			string response;
			Console.WriteLine($"please input {requestedInfo}: ");
			response = Console.ReadLine().Trim();

			int number;

			while (!int.TryParse(response, out number))
			{
				Console.WriteLine($"Please enter {requestedInfo} as a whole number: ");
				response = Console.ReadLine().Trim();
			}

			return number;

		}
	}
}
