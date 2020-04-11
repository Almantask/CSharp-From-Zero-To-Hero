using System;
using System.Collections.Generic;
using System.Reflection.Metadata;
using System.Runtime.CompilerServices;
using System.Text;

namespace BootCamp.Chapter
{
    class Lesson3
    {
        public static float IsNumber(string input)
        {
            if ((input) == "0") return 0f;

            var isNumber = float.TryParse(input, out var result);
            if (!isNumber) 
            {
                Console.WriteLine(@"""" + input + @""" " + "is not a valid number.");

                return -1f;
            }
            
            return result;
        }
        
        public static string GetString(string message)
        {
            Console.WriteLine(message);
            var string1 = Console.ReadLine();
           
            bool isEmpty = string1 == "";
            if (isEmpty)
            {
                Console.WriteLine("Name cannot be empty.");
                return "-";
            }

            return string1;
        }
       
        public static int GetInt(string message)
        {
            Console.WriteLine(message);
            string int1 = Console.ReadLine();
            var isInt = IsNumber(int1);
            int result = Convert.ToInt32(isInt);
            return (result);
        }
       
        public static float GetFloat(string message)
        {
            Console.WriteLine(message);
            string float1 = Console.ReadLine();
            var isFloat = IsNumber(float1);
           
            return isFloat;
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
