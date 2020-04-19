using System;

namespace BootCamp.Chapter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hi, welcome to my BMI calculator can you start by telling me your name?");
            string name1 = Console.ReadLine();

            Console.WriteLine("Hi" + " " + name1 + ", " + "Can you tell me your age please?");
            int age1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Great you are " + age1 + " years old, now can you tell me your weight in kg please?");
            double weight1 = double.Parse(Console.ReadLine());

            Console.WriteLine("And lastly, Can you tell me your height in cm please?");
            double height1 = double.Parse(Console.ReadLine());

            double height1Meters = height1 / 100;
            double height1MetersSquared = height1Meters * height1Meters;
            double bmi1 = weight1 / height1MetersSquared;

            Console.WriteLine("Ok, based on the information you have provided your BMI is" + " " + bmi1);

            Console.WriteLine("Now can I please ask the second person the same questions to determine their BMI?");

            Console.WriteLine("Hi, welcome to my BMI calculator can you start by telling me your name?");
            string name2 = Console.ReadLine();

            Console.WriteLine("Hi" + " " + name2 + ", " + "Can you tell me your age please?");
            int age2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Great you are " + age2 + " years old, now can you tell me your weight in kg please?");
            double weight2 = double.Parse(Console.ReadLine());

            Console.WriteLine("And lastly, Can you tell me your height in cm please?");
            double height2 = double.Parse(Console.ReadLine());

            double height2Meters = height2 / 100;
            double height2MetersSquared = height2Meters * height2Meters;
            double bmi2 = weight2 / height2MetersSquared;

            Console.WriteLine("Ok, based on the information you have provided your BMI is" + " " + bmi2);
        }
    }
}
