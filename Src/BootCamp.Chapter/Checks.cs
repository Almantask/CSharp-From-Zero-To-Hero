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
            int integer = Program.AskingAndConvertingINT();
            return integer;
        }

        public static string PromptString(string message)
        {
            string thePrompt = Program.AskingAndConvertingSTRING();
            return thePrompt;
        }

        public static float PromptFloat(string message)
        {
            float number = Program.AskingAndConvertingFLOAT();
            return number;
        }

        public static float CalculateBmi(float weight, float height)
        {
            float theBmi = Program.CalculateBMI(weight, height);
            return theBmi;
        }
    }
}
