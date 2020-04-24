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
        public static int ParseInt(string input)
        {
            bool isNumber = int.TryParse( input, out var output);
            if (output < 0) return -1;
            if (!isNumber) return -1;

            else
            {
                return output;
            }
        }

        public static string ParseName(string input)
        {
            bool isEmpty = string.IsNullOrEmpty(input);

            if (isEmpty) return "x";

            else
            {
                return input;
            }

        }

        public static string Empty(string input)
        {
            bool isEmpty = string.IsNullOrEmpty(input);

            if (isEmpty) return input = null;

            else
            {
                return input;
            }


        }



        public static float CalculateBmi(float weight, float height)
        {
            return weight / height / height * 1f;
        }
    }
}
