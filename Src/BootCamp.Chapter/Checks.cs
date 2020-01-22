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
        public static int PromptInt(string checkString)
        {
            Console.Write(checkString);
            int returnInt = int.Parse(Console.ReadLine());
            return returnInt;
        }

        public static string PromptString(string checkString)
        {
            Console.Write(checkString);
            string returnString = Console.ReadLine();
            return returnString;
        }

        public static float PromptFloat(string checkString)
        {
            Console.Write(checkString);
            float returnFloat = float.Parse(Console.ReadLine());
            return returnFloat;
        }

        public static float CalculateBodyMassIndex(float weight, float height)
        {
            return weight / ((height / 100) * (height / 100));
        }
    }
}
