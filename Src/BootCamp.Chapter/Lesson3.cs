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
            var isEmpty = String.IsNullOrEmpty(input);
            if (isEmpty) return 0f;
            
            var isNumber = float.TryParse(input, out var result);
            if (!isNumber) 
            {
                Console.Write(@"""" + input + @""" " + "is not a valid number.");

                return -1f;
            }
            
            return result;
        }
        
        public static string PromptString(string message)
        {
            Console.WriteLine(message);
            
            var input = Console.ReadLine();

            bool isEmpty = String.IsNullOrEmpty(input);
            if (isEmpty)
            {
                Console.Write("Name cannot be empty.");

                return "-";
            }

            return input;
        }
       
        public static int PromptInt(string message)
        {
            Console.WriteLine(message);
            
            string number = Console.ReadLine();
            
            var isInt = IsNumber(number);
            
            int result = Convert.ToInt32(isInt);
            
            return (result);
        }
       
        public static float PromptFloat(string message)
        {
            Console.WriteLine(message);
            
            string number = Console.ReadLine();
            
            var isFloat = IsNumber(number);
           
            return isFloat;
        }

        public static float CalculateBmi(float weight, float height)
        {
            string heightError = ("Height cannot be equal or less than zero, but was " + height);
            string weightError = ("Weight cannot be equal or less than zero, but was " + weight);
            string failedCalc = ("Failed calculating BMI. Reason:");

            bool isWeight0OrLess = ((weight) <= 0);
            bool isHeight0OrLess = ((height) <= 0);

            if (isHeight0OrLess && isWeight0OrLess)
            {
                Console.WriteLine(failedCalc);
                Console.WriteLine(weightError + '.' + Environment.NewLine + "Height cannot be less than zero, but was " + height + '.');

                return -1f;
            }

            if (isWeight0OrLess)
            {
                Console.WriteLine(failedCalc);
                Console.WriteLine(weightError + '.');
                return -1f;
            }

            if (isHeight0OrLess)
            {
                Console.WriteLine(failedCalc);
                Console.WriteLine(heightError + '.');
                return - 1f;
            }

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
