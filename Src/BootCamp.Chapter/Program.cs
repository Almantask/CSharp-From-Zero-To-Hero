using System;
using System.Collections.Generic;
using System.IO;
using Console = System.Console;

namespace BootCamp.Chapter
{
    class Program
    {
        static void Main(string[] args)
        {
            PrintBMI();
            PrintBMI();
        }
            
         static string AskName(string name)
        {
            Console.WriteLine(name);
            return Console.ReadLine();           
        }
   
          static int AskAge(string age)
        {
            Console.WriteLine(age);
            return Int32.Parse(Console.ReadLine());       
        }

         static float AskMeasurements(string Measurements)
        {
            Console.WriteLine(Measurements);
            return float.Parse(Console.ReadLine());           
        }       

        static void Print(string name1, double bmi)
        {
            Console.WriteLine(name1 + "'s BMI is " + bmi);
        }
        
        static float CalculateBodyMassIndex(float height, float weight)
        {  
            float heightInMetersSquared = height/100.0f;
            heightInMetersSquared *= heightInMetersSquared;
            var bodyMassIndex = weight / heightInMetersSquared;
            return bodyMassIndex;
        }
               
         static void PrintBMI()
        {
            string name1 = AskName("What is the patient's name?");
            int age1 = AskAge("How old are they?");
            float weight1 = AskMeasurements("What is their weight in kg?");
            float height1 = AskMeasurements("What is their height in cm?");
            var bmi = CalculateBodyMassIndex(height1, weight1);
            Console.WriteLine(name1 + " is " + age1 + " years old, their weight is " + weight1 + " kg and their height is " + height1 + " cm.");
            Print(name1, bmi);
        }
    }
}
        
