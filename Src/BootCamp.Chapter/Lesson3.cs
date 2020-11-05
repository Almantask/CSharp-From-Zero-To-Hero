using System;
using System.Collections.Generic;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Text;

namespace BootCamp.Chapter
{
    class Lesson3
    {
        public static string promptStr(string message)
        {
            Console.WriteLine(message);
            string variable = Console.ReadLine();
            if (string.IsNullOrEmpty(variable)) 
            {
                Console.WriteLine("Name cannot be empty");
                return "-";                  
            }
            return variable;
        }

        public static int promptInt(string message)
        {
            Console.WriteLine(message);
            var input = Console.ReadLine();
            var isNumber = int.TryParse(input, out var age);
            if (!isNumber)
            {
                Console.WriteLine(input + " is not a valid number");
                return -1;
            }
            return age;
        }

        public static float promptFloat(string message)
        {
            Console.WriteLine(message);
            float variable = float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            return variable;
        }

        public static float calculateBMI(float weight, float height)
        {
            string always = "Failed calculating BMI. Reason:";
            string errorWeight = " Weight cannot be equal or less than zero, but was " + weight + ".";
            string errorHeight = " Height cannot be equal or less than zero, but was " + height + ".";

            bool doubleError = weight <= 0 && height <= 0;
            if (doubleError) 
            {
                Console.WriteLine(always + errorWeight + errorHeight);
                return -1;
            }              
                        
            bool weightError = weight <= 0;
            if (weightError)
            {
                Console.WriteLine(always + errorWeight);
                return -1;
            }

            bool heightError = height <= 0;
            if (heightError)
            {
                Console.WriteLine(always + errorHeight);
                return -1;
            }
            
            float BMI = weight / (height * height);
            Console.WriteLine("Your BMI is " + BMI);
            return BMI;
        } 
    }
}
