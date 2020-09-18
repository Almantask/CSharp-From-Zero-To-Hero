using System;
using System.Collections.Generic;
using System.Runtime.Intrinsics.X86;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Globalization;

namespace BootCamp.Chapter
{
    class Lesson3
    {
        public static void Demo()
        {
            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine("Hello first person, what's your first name?");
                string firstName = Console.ReadLine();
                Console.WriteLine("What's your second name?");
                string secondName = Console.ReadLine();
                Console.WriteLine("What's your age?");
                int age = int.Parse(Console.ReadLine());
                Console.WriteLine("What's your weight? (In kg)");
                float weight = float.Parse(Console.ReadLine());
                Console.WriteLine("What's your height? (In cm)");
                float height = float.Parse(Console.ReadLine());

                Console.WriteLine(firstName + " " + secondName + " is " + age + " years old, his weight is " + weight + " kg and his height is " + height + " cm.");
                Console.WriteLine("Your body-mass index (BMI) is: " + (weight / ((height / 100) * (height / 100))));
            }

        }
        public static int PromptInt(string message)
        {
            Console.WriteLine(message);
            return int.Parse(Console.ReadLine());
        }
        public static string PromptString(string message)
        {
            Console.WriteLine(message);
            return Console.ReadLine();
        }
        public static float PromptFloat(string message)
        {
            Console.WriteLine(message);
            return float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        }
        public static float CalculateBmi(float weight, float height)
        {
            return (weight / ((height / 100) * (height / 100)));
        }
    }
}
