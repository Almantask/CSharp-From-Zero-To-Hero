using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace BootCamp.Chapter
{
    internal class Lesson3
    {
        public static void Demo() 
        {
            string firstName = "";
            string surname = "";
            int age = 0;
            int weight = 0;
            double height = 0.0;
            double bmi = 0.0;

            for (int i = 0; i < 2; i++)
            {

                Console.Write("Enter your first name: ");
                firstName = Console.ReadLine();
                Console.Write("Enter your surname: ");
                surname = Console.ReadLine();
                Console.Write("Enter your age: ");
                age = int.Parse(Console.ReadLine());
                Console.Write("Enter your weight in kg: ");
                weight = int.Parse(Console.ReadLine());
                Console.Write("Enter your height in cm: ");
                height = double.Parse(Console.ReadLine());


                bmi = weight / Math.Pow((height / 100), 2);

                Console.WriteLine($"\n{firstName} {surname} is {age} years old, his weight is {weight} kg, and his height is {height} cm.");

                Console.WriteLine("Your BMI is: {0}\n", bmi);
            }

        }

        public static float CalculateBmi(float weight, float height)
        {
            return weight / (float)Math.Pow(height, 2);
        }

        public static int PromptInt(string message)
        {
            Console.WriteLine(message);
            int number = int.Parse(Console.ReadLine());
            return number;
        }

        public static float PromptFloat(string message)
        {
            Console.WriteLine(message);
            var number = float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture) ;
            return number;
        }

        public static string PromptString(string message)
        {
            Console.WriteLine(message);
            string input = Console.ReadLine();
            return input;
        }
    }
}
