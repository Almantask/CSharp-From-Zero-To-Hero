using System;
using System.Collections.Generic;
using System.Reflection.Metadata;
using System.Runtime.CompilerServices;
using System.Text;

namespace BootCamp.Chapter
{
    class Lesson3
    {
        public static string PromptString(string message)
        {
            Console.WriteLine(message);
            string text= Console.ReadLine();
            return text;
        }
        public static int PromptInt(string message)
        {
            Console.WriteLine(message);
            int number = Convert.ToInt32(Console.ReadLine());
            return number;
        }
        public static float PromptFloat(string message)
        {
            Console.WriteLine(message);
            float number = float.Parse(Console.ReadLine());
            return number;
        }
        public static float CalculateBmi(float weight, float height)
        {
            float bmi = (weight / height / height);
            return bmi;
        }

        public static void Demo()
        {
            Process2PersonInfo();
        }
        
        static void ProcessPersonInfo(string userNo)
        {
            string name = PromptString("Hello " + userNo + " user! What's your name?");
            string surname = PromptString("Great, and what's your surname?");
            int age = PromptInt("Amazing, and how old are you?");
            float weight = PromptFloat("Cool, and what's your weight?");
            float height = PromptFloat("Groovie, and how tall are you (in meters)?");
            float bmi = CalculateBmi(weight, height);

            Console.WriteLine(name + " " + surname + " is " + age + " years old, his weight is " + weight + " kg and his height is " + height + " cm.");
            Console.WriteLine("Based on this information, your BMI is " + bmi);
        }

        static void Process2PersonInfo()
        {
            ProcessPersonInfo("first");
            ProcessPersonInfo("second");
        }
    }
}

