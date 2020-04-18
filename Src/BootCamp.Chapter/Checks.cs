using System;
using System.Collections.Generic;
using System.Runtime.Intrinsics.X86;
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
            int number = Lesson3.PromptInt(message);
            return number;
        }

        public static string PromptString(string message)
        {
            string text = Lesson3.PromptString(message);
            return text;
        }

        public static float PromptFloat(string message)
        {
            float number = Lesson3.PromptFloat(message);
            return number;
        }

        public static float CalculateBmi(float weight, float height)
        {
            float bmi = Lesson3.CalculateBmi(weight, height);
            return bmi;
        }
    }
}
