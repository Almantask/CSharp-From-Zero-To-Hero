using System;
using System.Collections.Generic;
using System.Reflection.Metadata;
using System.Runtime.CompilerServices;
using System.Text;

namespace BootCamp.Chapter
{
    class Lesson3
    {
        public static string GetString(string message)
        {
            Console.WriteLine(message);
            string string1= Convert.ToString(Console.ReadLine());
            return string1;
        }
        public static int GetInt(string message)
        {
            Console.WriteLine(message);
            int int1 = Convert.ToInt32(Console.ReadLine());
            return int1;
        }
        public static float GetFloat(string message)
        {
            Console.WriteLine(message);
            float float1 = float.Parse(Console.ReadLine());
            return float1;
        }
        public static float Bmi(float weight, float height)
        {
            float bmi = (weight / height / height);
            return bmi;
        }
       
        public static void Demo()
        {
            static void GatherAndPrint(string userNo)
            {
                string name = GetString("Hello " + userNo + " user! What's your name?");
                string surname = GetString("Great, and what's your surname?");
                int age = GetInt("Amazing, and how old are you?");
                float weight = GetFloat("Cool, and what's your weight?");
                float height = GetFloat("Groovie, and how tall are you (in meters)?");
                float bmi = Bmi(weight, height);

                Console.WriteLine(name + " " + surname + " is " + age + " years old, his weight is " + weight + " kg and his height is " + height + " cm.");
                Console.WriteLine("Based on this information, your BMI is " + bmi);
            }

            GatherAndPrint("first");
            GatherAndPrint("second");
        }
    }
}
