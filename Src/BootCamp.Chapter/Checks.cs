using System;
using System.Collections.Generic;
using System.Text;

namespace BootCamp.Chapter
{
    /// <summary>
    /// Test class is used to test your implementation.
    /// Each homework will have a set of steps that you will have to do.
    /// You can name your functions however you want, but to validate your solution, place them here.
    /// DO NOT CALL FUNCTIONS FROM TESTS CLASS
    /// DO NOT IMPLEMENT FUNCTIONS IN TESTS CLASS
    /// TESTS CLASS FUNCTIONS SHOULD ALL HAVE 1 LINE OF CODE
    /// </summary>
    public static class Checks
    {
        public static int PromptInt(string message)
        {
            Console.Write(message);
            int age = int.Parse(Console.ReadLine());
            return age;
        }

        public static string PromptString(string message)
        {
            Console.Write(message);
            string promptname = Console.ReadLine();
            return promptname;
        }

        public static float PromptFloat(string message)
        {
            Console.Write(message);
            float promptinfo = float.Parse(Console.ReadLine());
            return promptinfo;
        }

        public static float CalculateBmi(float weightkg, float heightm)
        {
            float bmi = weightkg / (heightm * heightm);
            return bmi;
        }
    }
}