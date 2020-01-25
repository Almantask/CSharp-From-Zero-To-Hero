// This file is for hunting bugs only.
// Completing homework 3 before looking at this is HIGHLY recommended.
// Try to look at the code in GitHub first. Try to find the mistakes that
// were made without help or tools first.
// After that try to find every single thing that seems off.
// Have fun! :)
namespace BootCamp.Chapter
{
    public static class Checks
    {
        public static string PromptString(string message)
        {
            return Lesson3.PromptString(message);
        }

        public static int PromptInt(string message)
        {
            return Lesson3.ReadMyInput(message);
        }

        public static float PromptFloat(string message)
        {
            return Lesson3.AsFloat(message);
        }

        public static float WhatIsTheBmi(float weight, float heigth)
        {
            return Lesson3.CalcBmi(weight, heigth);
        }
    }
}