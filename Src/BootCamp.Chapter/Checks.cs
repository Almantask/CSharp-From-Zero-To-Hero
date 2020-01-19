﻿using System;
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
            Lesson3.RequestInt(message);
            return 0;
        }

        public static string PromptString(string message)
        {
            Lesson3.RequestString(message);
            return "";
        }

        public static float PromptFloat(string message)
        {
            Lesson3.RequestDouble(message);
            return 0;
        }

        public static float CalculateBmi(float weight, float height)
        {
            Lesson3.CalculateBodyMassIndex(weight, height);
            return 0;
        }
    }
}