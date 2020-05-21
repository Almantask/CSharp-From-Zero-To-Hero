using System;

namespace BootCamp.Chapter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");



			string myName = "Tom Jefferson";

			int myAge = 19;

			int weight = 50;

			float height = 156.5f;

			// BMI formula weight(kg) divided by height(cm)^2 multiplied by 10000
			double sum = 156.5 * 156.5;
			double sum2 = weight / sum;
			double bmi = sum2 * 10000;

			string greetings = "years old";
			var completeSentence = myName + " is " + myAge + " " + greetings + ", his weight is " + weight + "kg" + " and his height is " + height + "cm" + " BMI " + bmi;
			Console.WriteLine(completeSentence);


			string name = "Sandor Clegane";

			var completeSense = name + " is " + myAge + " " + greetings + ", his weight is " + weight + "kg" + " and his height is " + height + "cm" + " BMI " + bmi;
			Console.WriteLine(completeSense);


			string nickName = "Onion Knight";

			var complete = nickName + " is " + myAge + " " + greetings + ", his weight is " + weight + "kg" + " and his height is " + height + "cm" + " BMI " + bmi;
			Console.WriteLine(complete);


		}
    }
}
