using System;
using System.Collections.Generic;
using System.Text;

namespace BootCamp.Chapter
{
    class Lesson3
    {
    
        public static int PromptInt(string message)
        {
            int variable;
            Console.WriteLine(message);
            variable = int.Parse(Console.ReadLine());
            return variable;
        }

        public static string PromptString(string message)
        {
            string variable;
            Console.WriteLine(message);
            variable = Console.ReadLine();
            return variable;
        }


        public static float PromptFloat(string message)
        {
            float variable;
            Console.WriteLine(message);
            variable = float.Parse(Console.ReadLine());
            return variable;
        }


        public static float CalculateBmi(float weight, float height)
        {
            float Bmi;
            Bmi = weight /(height*height);
            return Bmi;
        }
    }
}


