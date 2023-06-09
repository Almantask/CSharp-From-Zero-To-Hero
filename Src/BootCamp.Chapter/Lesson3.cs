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
				string firstName;
				do
				{
					firstName = ReadLineString("First Name: ");
				} while (firstName.Equals("-"));

				//Last name
				string lastName;
				do
				{
					lastName = ReadLineString("Last Name: ");
				} while (lastName.Equals("-"));

				//Age
				int age;
				do
				{
					age = ReadLineInt("Age: ");
				} while (age == -1);

				//Weight
				float kgWeight;
				do
				{
					kgWeight = ReadLineFloat("Weight(kg): ");
				} while (kgWeight == -1);

				//Height
				float mHeight;
				do
				{
					mHeight = ReadLineFloat("Height(m): ");
				} while (mHeight == -1);

				//Print all variables on one line
				Console.WriteLine($"{firstName} {lastName} is {age} years old, their weight is {kgWeight} kg and their height is {mHeight} m.");

				//Print BMI
				float bmi = GetBMI(kgWeight, mHeight);
				if (bmi >= 0)
				{
					Console.WriteLine($"BMI: {bmi}");
				}
			}

			//Wait to exit
			Console.ReadLine();
		}

		public static string ReadLineString(string prompt)
		{
			Console.Write(prompt);
			string input = Console.ReadLine();

			//Error if blank
			if (string.IsNullOrEmpty(input))
			{
				Console.WriteLine("Name cannot be empty.");
				return "-";
			}

			return input;
		}

		public static float ReadLineFloat(string prompt)
		{
			string input;
			float num = 0;

			Console.Write(prompt);
			input = Console.ReadLine();

			//Parse failed
			if (!Single.TryParse(input, out num))
			{
				Console.WriteLine($"\"{input}\" is not a valid number.");
				return -1;
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
			bool isValidWeight = (kgWeight > 0);
			bool isValidHeight = (mHeight > 0);

			//Error if either inputs are invalid
			if (!isValidWeight || !isValidHeight)
			{
				Console.WriteLine("Failed calculating BMI. Reason:");

				if (!isValidWeight)
				{
					Console.WriteLine($"Weight cannot be equal or less than zero, but was {kgWeight}.");
				}
				if (!isValidHeight)
				{
					Console.WriteLine($"Height cannot be equal or less than zero, but was {mHeight}.");
				}

				return -1;
			}

			float bmi = kgWeight / (mHeight * mHeight);

			return (float)Math.Round((decimal)bmi, 1);
		}
	}
}