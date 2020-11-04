using System;
using System.Collections.Generic;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Text;

namespace BootCamp.Chapter
{
    class Lesson3
    {
        //Return Str Function
        public static string printStr(string message, string variable)
        {
            Console.WriteLine(message);
            variable = Console.ReadLine();
            if (string.IsNullOrEmpty(variable)) 
            {
                Console.WriteLine("Name cannot be empty");
                return "-";                  
            }
            return variable;
        }

        //Return Int Function
        public static int printInt(string message, int variable)
        {
            Console.WriteLine(message);
            var input = Console.ReadLine();
            var isNumber = int.TryParse(input, out var age1);
            if (!isNumber)
            {
                Console.WriteLine(input + " is not a valid number");
                return -1;
            }
            return variable = age1;
        }

        //Return Float Function
        public static float printFloat(string message, float variable)
        {
            Console.WriteLine(message);
            variable = float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            return variable;
        }

        //Return BMI Function
        public static float printBMI(float var1, float var2)
        {
            string always = "Failed calculating BMI. Reason:";
            string errorWeight = " Weight cannot be equal or less than zero, but was " + var1;
            string errorHeight = " Height cannot be equal or less than zero, but was " + var2;

            bool error1 = var1 <= 0 && var2 <= 0;
            if (error1) 
            {
                Console.WriteLine(always + errorWeight + errorHeight);
                return -1;
            }              
                        
            bool error2 = var1 <= 0;
            if (error2)
            {
                Console.WriteLine(always + errorWeight);
                return -1;
            }

            bool error3 = var2 <= 0;
            if (error3)
            {
                Console.WriteLine(always + errorHeight);
                return -1;
            }
                       
            float BMI = var1 / (var2 * var2);
            Console.WriteLine("Your BMI is " + BMI);
            return BMI;
        } 
         
       


    }

    
}
