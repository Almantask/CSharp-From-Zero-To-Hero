using System;
using System.Collections.Generic;
using System.Text;

namespace BootCamp.Chapter
{
    class Lesson3
    {
        private static void CheckAndResetWindowSize() // my consol is bugged, that is the only reason why this stuff exist.
        {
            if (Console.WindowHeight != 300 || Console.WindowWidth != 500)
            {
                Console.SetWindowSize(120, 40);
            }
        }
        public static void Demo()
        {
            CheckAndResetWindowSize();
            StuffThatExistTwice();
            StuffThatExistTwice();
        }
        static void StuffThatExistTwice()
        {
            string name = Name();
            double age = Age();
            double weight = Weight();
            double height = Height();
            double BMI = Math.Round(weight / Math.Pow(height/100,2),2);
            Console.WriteLine($"{name} is {age} old, their weight is {weight}kg and their height is {height}cm\n Their BMI index is {BMI}");//their is used instead of his/her.

        }
        static void Text(string text)
        {
            Console.WriteLine(text);
        }
        static double Weight()
        {
            Text("Please give me your weight in kg");
            double age = double.Parse(Console.ReadLine());
            return age;
        }
        static string Name()
        {
            Text("Please give me your name");
            string Name = Console.ReadLine();
            return Name;
        }
        static double Age()
        {
            Text("Please give me your age");
            double weight = double.Parse(Console.ReadLine());
            return weight;
        }
        static double Height()
        {
            Text("Please give me your height");
            double height = double.Parse(Console.ReadLine());
            return height;
        }
    }
}
