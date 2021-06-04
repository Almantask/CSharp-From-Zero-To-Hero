using System;

namespace BootCamp.Chapter
{
    class Program
    {
        // Running with VS menu will put application in debugging mode.
        // Running with "ctrl + F5" will put it in release mode.
        static void Main(string[] args)
        {
            Console.WriteLine("Hello! \nWhat is your name?");
            var name = Console.ReadLine();
            Console.WriteLine("And what is your height in Inches?");
            var heightinches = Console.ReadLine();
            Console.WriteLine("Your age?");
            var age = Console.ReadLine();
            Console.WriteLine("Finally, what is your weight in pounds?");
            var weight = Console.ReadLine();

            Console.WriteLine(name + " is " + age + " years old, his weight is " + weight + " lbs, and his height is " + heightinches + " inches.");

            var bmi_1 = Convert.ToInt16(heightinches) * Convert.ToInt16(heightinches);
            var bmi_2 = float.Parse(weight) / bmi_1;
            var bmi_3 = bmi_2 * 703;
            Console.WriteLine(name + "'s Body Mass Index is also " + bmi_3 + "!");
        }
    }
}
