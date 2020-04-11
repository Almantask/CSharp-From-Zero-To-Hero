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
            int age = Lesson3.GetInt(message);
            // To do: call your implementation. 
            
            return age;
        }

        public static string PromptString(string message)
        {
            string surname = Lesson3.GetString(message);
            // To do: call your implementation. 
            return surname;
        }

        public static float PromptFloat(string message)
        {
            float weight = Lesson3.GetFloat(message);
            // To do: call your implementation. 
            return weight;
        }

        public static float CalculateBmi(float weight, float height)
        {
            float bmi = Lesson3.Bmi(weight,height);
            // To do: call your implementation. 
            return bmi;
        }
    }
}
