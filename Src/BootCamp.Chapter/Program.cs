using System;
using System.Collections.Generic;
using System.IO;
using System.Transactions;
using Console = System.Console;

namespace BootCamp.Chapter
{
    class Program


    {
        static void Main(string[] args)
        {

            BmiCalculator();
            BmiCalculator();
        }

        public static void BmiCalculator()
        {
            String myName = PromptString("Enter in your full name");
            int age = PromptInt("Enter your age");
            float height = PromptFloat("Enter your height");
            float weight = PromptFloat("Enter your weight");
            float bmi = calculateBmi(weight, height);
            Console.WriteLine(myName + " is " + age + " years old, his height is " + height + "cm, and his weight is " + weight + "kg.");
            Console.WriteLine("BMi is: " + bmi);
            
        }

        public static int PromptInt(string message)
        {
            Console.WriteLine(message);
            return int.Parse(Console.ReadLine());

        }
        public static string PromptString(string message)
        {
            Console.WriteLine(message);
            return Console.ReadLine();
            
        }
        public static float PromptFloat(string message)
        {
            Console.WriteLine(message);
            return float.Parse(Console.ReadLine());
           
        }

        public static float calculateBmi(float weight, float height)
        {
           return weight/ (height * height);
            
        }
        


        
    }
    
}
