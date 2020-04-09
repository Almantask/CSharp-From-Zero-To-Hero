using System;
using System.Runtime.Intrinsics.X86;

namespace BootCamp.Chapter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello first user! What's your name?");
            string name1 = Console.ReadLine();
            Console.WriteLine("Great, and what's your surname?");
            string surname1 = Console.ReadLine();
            Console.WriteLine("Amazing, and how old are you?");
            string age1 = Console.ReadLine();
            Console.WriteLine("Cool, and what's your weight?");
            string weight1 = Console.ReadLine();
            float w1 = float.Parse(weight1);
            Console.WriteLine("Groovie, and how tall are you?");
            string height1 = Console.ReadLine();
            float h1 = float.Parse(height1);
            float bmi1 = (w1 / h1 / h1) * 10000;

            Console.WriteLine(name1 + " " + surname1 + " is " + age1 + " years old, his weight is " + weight1 + " kg and his height is " + height1 + " cm.");
            Console.WriteLine("Based on this information, your BMI is " + bmi1);

            Console.WriteLine("Hello second user! What's your name?");
            string name2 = Console.ReadLine();
            Console.WriteLine("Great, and what's your surname?");
            string surname2 = Console.ReadLine();
            Console.WriteLine("Amazing, and how old are you?");
            string age2 = Console.ReadLine();
            Console.WriteLine("Cool, and what's your weight?");
            string weight2 = Console.ReadLine();
            float w2 = float.Parse(weight2);
            Console.WriteLine("Groovie, and how tall are you?");
            string height2 = Console.ReadLine();
            float h2 = float.Parse(height2);
            float bmi2 = (w2 / h2 / h2) * 10000;

            Console.WriteLine(name2 + " " + surname2 + " is " + age2 + " years old, his weight is " + weight2 + " kg and his height is " + height2 + " cm.");
            Console.WriteLine("Based on this information, your BMI is " + bmi2);
        }
    }
}
