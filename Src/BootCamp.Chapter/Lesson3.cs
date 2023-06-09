using System;
using System.Collections.Generic;
using System.Text;

namespace BootCamp.Chapter
{
	internal class Lesson3
	{
		public static void Demo()
		{
			//Get 2 sets of inputs
			for (int i = 0; i < 2; i++)
			{
				//Get user inputs
				//First name
				string firstName = ReadLineString("First Name: ");

				//Last name
				string lastName = ReadLineString("Last Name: ");

				//Age
				int age = ReadLineInt("Age: ");

				//Weight
				float kgWeight = ReadLineFloat("Weight(kg): ");

				//Height
				float cmHeight = ReadLineFloat("Height(cm): ");


				//Print all variables on one line
				Console.WriteLine($"{firstName} {lastName} is {age} years old, their weight is {kgWeight} kg and their height is {cmHeight} cm.");

				//Print BMI
				float bmi = GetBMI(kgWeight, cmHeight);
				Console.WriteLine($"BMI: {bmi}");
			}

			//Wait to exit
			Console.ReadLine();
		}

		public static string ReadLineString(string prompt)
		{
			Console.Write(prompt);
			return Console.ReadLine();
		}

		public static float ReadLineFloat(string prompt)
		{
			bool isNumber = false;
			string input;
			float num = 0;


			while (!isNumber)
			{
				Console.Write(prompt);
				input = Console.ReadLine();
				isNumber = Single.TryParse(input, out num);
			}

			return num;
		}

		public static int ReadLineInt(string prompt)
		{
			//Can just call the float function and convert to int
			return (int)ReadLineFloat(prompt);
		}

		public static float GetBMI(float kgWeight, float mHeight)
		{
			float bmi = kgWeight / (mHeight * mHeight);

			return (float)Math.Round((decimal)bmi, 1);
		}
	}
}
