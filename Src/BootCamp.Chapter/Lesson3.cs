using System;
using System.Collections.Generic;
using System.Text;

namespace BootCamp.Chapter
{
    class Lesson3
    {
        //Calls all user prompt methods & prints full message to console
        public static void Demo()
        {
            string name = PromptName();
            int age = PromptAge();
            float weight = PromptWeight();
            float height = PromptHeight();
            float bmi = CalculateBmi(weight, height);
            Console.WriteLine(name + " is " + age + " years old, their weight is " + weight + " kg, and their height is " + height + " cm.");
            Console.WriteLine("Their BMI is: " + bmi);
        }

        //Prompting user for info
        public static string PromptName()
        {
            Console.Write("Testing");
            return Console.ReadLine();
        }
        public static int PromptAge()
        {
            Console.Write("Testing");
            return int.Parse(Console.ReadLine());
        }
        public static float PromptWeight()
        {
            Console.Write("Testing");
            return float.Parse(Console.ReadLine());
        }
        public static float PromptHeight()
        {
            Console.Write("Testing");
            return float.Parse(Console.ReadLine());
        }
        //Calculates BMI
        public static float CalculateBmi(float weight, float height)
        {
            return weight / (height * height);
        }
    }
}