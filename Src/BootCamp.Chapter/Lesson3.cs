using System;
using System.Collections.Generic;
using System.Text;

namespace BootCamp.Chapter
{
    class Lesson3
    {
 
        public static void Demo()
        {
            string name = "";
            int age = 0;
            float weight = 0;
            float height = 0;

            name = PromptString("Name: ");
            age = PromptInt("Age: ");
            weight = PromptFloat("Weight(kg): ");
            height = PromptFloat("Height(cm): ");

            float bmi = CalculateBMI(weight, height);

            Console.WriteLine($"{name} is {age} years old, his weight is {weight} kg and his height is {height} cm.");
            Console.WriteLine($"BMI is: {bmi}");
        }

        public static string PromptString(string message)
        {
            string variable;
            Console.WriteLine(message);
            variable = Console.ReadLine();
            return variable;
        }

        public static int PromptInt(string message)
        {
            int variable;
            Console.WriteLine(message);
            variable = int.Parse(Console.ReadLine());
            return variable;
        }

        public static float PromptFloat(string message)
        {
            float variable;
            Console.WriteLine(message);
            variable = float.Parse(Console.ReadLine());
            return variable;
        }

        public static float CalculateBMI(float w, float h)
        {
            float bmi;
            bmi = w / (h * h);
            return bmi;
        }

    }
}
