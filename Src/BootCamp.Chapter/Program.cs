using System;

namespace BootCamp.Chapter
{
    class Program
    {
        static void Main(string[] args)
        {
            // Loop twice. Can be changed by altering the number that "i" is less than.
            for (int i = 0; i < 2; i++)
            {
                // Get name, age, weight, and height from the user.
                Console.Write("Please enter your surname: ");
                var name = Console.ReadLine();
                Console.Write("Please enter your age: ");
                var age = Console.ReadLine();
                Console.Write("Please enter your weight (in kg): ");
                var weight = Console.ReadLine();
                Console.Write("Please enter your height (in m): ");
                var height = Console.ReadLine();
                // Set the user data in a sentence and then write it to the console.
                var sentence = (name + " is " + age + " " + "years old, his weight is " + weight + "kg and his height is " + height + "m.");
                Console.WriteLine(sentence);
                // Double height in preparation for calculating BMI.
                var heightToDouble = Convert.ToDouble(height) * Convert.ToDouble(height);
                // Convert weight to a Double.
                var weightToDouble = Convert.ToDouble(weight);
                //Calculate BMI.
                Double Bmi = weightToDouble / heightToDouble;
                //Convert BMI from Double to Int for better readability by the user.
                var BmiFinal = Convert.ToInt32(Bmi);
                var BmiOutput = ("Your estimated BMI is " + BmiFinal);
                Console.WriteLine(BmiOutput);
            }
        }
    }
}
