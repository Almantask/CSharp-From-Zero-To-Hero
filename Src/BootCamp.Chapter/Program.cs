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
            PersonOneBMI();
            PersonTwoBMI();
        }
            
         static string Name(string askName)
        {
            Console.WriteLine(askName);
            return Console.ReadLine();           
        }
   
          static int Age(string askAge)
        {
            Console.WriteLine(askAge);
            return Int32.Parse(Console.ReadLine());       
        }

         static float Measurements(string askMeasurements)
        {
            Console.WriteLine(askMeasurements);
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
               
         static void PersonOneBMI()
        {
            string name1 = Name("What is your name?");
            int age1 = Age("How old are you?");
            float weight1 = Measurements("What is your weight in kg?");
            float height1 = Measurements("What is your height in cm?");
            var bmi = CalculateBodyMassIndex(height1, weight1);
            Console.WriteLine(name1 + " is " + age1 + " years old, your weight is " + weight1 + " kg and your height is " + height1 + " cm.");
            Print(name1, bmi);
        }

        static void PersonTwoBMI()
        {
            string name2 = Name("What is your friend's name?");
            int age2 = Age("How old are they?");
            float weight2 = Measurements("What is their weight in kg?");
            float height2 = Measurements("What is their height in cm?");
            var bmi = CalculateBodyMassIndex(height2, weight2);
            Console.WriteLine(name2 + " is " + age2 + " years old, your weight is " + weight2 + " kg and your height is " + height2 + " cm.");
            Print(name2, bmi);
        }

    }
}
        
