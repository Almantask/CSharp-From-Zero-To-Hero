using System;
using System.Collections.Generic;
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
            return variable;
        }

        //Return Int Function
        public static int printInt(string message, int variable)
        {
            Console.WriteLine(message);
            variable = Int32.Parse(Console.ReadLine());
            return variable;
        }

        //Return Float Function
        public static float printFloat(string message, float variable)
        {
            Console.WriteLine(message);
            variable = float.Parse(Console.ReadLine());
            return variable;
        }

        //Return BMI Function
        public static void printBMI(float var1, float var2)
        {
            float BMI = var1 / (var2 * var2);
            Console.WriteLine("Your BMI is " + BMI);
        } 
         
       


    }

    
}
