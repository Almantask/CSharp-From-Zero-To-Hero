using System;
using static System.Math;
namespace BootCamp.Chapter
{
    class Lesson3
    {
        public static void Demo()
        {
            string cont = "y";
            do
            {
                cont = AddNewPerson();

            } while (cont.Equals("Y") || cont.Equals("y")); 
        }
        public static string AddNewPerson()
        {
            
            string name = PromptString("What is your name?");
            int age = PromptInteger("How old are you? If I may ask");
            float weight = PromptFloat("What is your weight? In kilograms, pretty please!");
            float height = PromptFloat("How tall are you? In meters, pretty please!");

            Console.WriteLine($"{name} is {age} years old, his weight is {weight} kg and his height is {height} cm.");

            float BMI = CalculateBmi(weight, height);

            Console.WriteLine("Their BMI  is " + BMI);

            Console.WriteLine("Do you wish to make an another round? Y/N ");
            string cont = Console.ReadLine();
            return cont;
        }
        public static int PromptInteger(string message)
        {
            Console.WriteLine(message);
            string input = Console.ReadLine();

            return int.Parse(input);
        }
        public static float PromptFloat(string message)
        {
            Console.WriteLine(message);
            string input = Console.ReadLine();

            return float.Parse(input);
        }
        public static string PromptString(string message)
        {
            Console.WriteLine(message);

            return Console.ReadLine();
        }

        public static float CalculateBmi(float weight, float height)
        {
            return weight / (float)Pow(height, 2);
        }
    }

}