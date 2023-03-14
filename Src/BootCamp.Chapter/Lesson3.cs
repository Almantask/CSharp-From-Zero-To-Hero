using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace BootCamp.Chapter
{
    internal class Lesson3
    {
        public static void Demo()
        {
            string name = PromptString("Enter person´s name");
            string surename = PromptString("Enter person´s surename");
            int age = PromptInt("Enter person´s age");
            float weight = PromptFloat("Enter person´s weight in kg");
            float height = PromptFloat("Enter person´s height in m");
            Console.WriteLine($"{Environment.NewLine}{name} {surename} is {age}, weight is {weight} kg and height is {height} cm.");
            Console.WriteLine($"BMI is {CalculateBMI(weight, height):f2}");

            Console.WriteLine("");

            name = PromptString("Enter person´s name");
            surename = PromptString("Enter person´s surename");
            age = PromptInt("Enter person´s age");
            weight = PromptInt("Enter person´s weight in kg");
            height = PromptInt("Enter person´s height in cm");
            Console.WriteLine($"{Environment.NewLine}{name} {surename} is {age}, weight is {weight} kg and height is {height} cm.");
            Console.WriteLine($"BMI is {CalculateBMI(weight, height):f2}");
        }

        public static string PromptString(string text)
        {
            Console.WriteLine(text);
            return Console.ReadLine();
        }

        public static int PromptInt(string text)
        {
            Console.WriteLine(text);
            return int.Parse(Console.ReadLine());
        }

        public static float PromptFloat(string text)
        {
            Console.WriteLine(text);
            return float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        }

        public static float CalculateBMI(float weight, float height)
        {
            return weight / (height * height);
        }


    }

}
