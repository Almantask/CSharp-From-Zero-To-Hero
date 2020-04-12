using System;
using System.Collections.Generic;
using System.Text;

namespace BootCamp.Chapter
{
    public static class Checks
    {
        public static int PromptInt(string message)
        {
            return Lesson4.PromptInt(message);
        }

        public static string PromptString(string message)
        {
            return Lesson4.PromptString(message);
        }

        public static float PromptFloat(string message)
        {
            return Lesson4.PromptFloat(message);
        }

        public static float CalculateBmi(float weight, float height)
        {
            return Lesson4.CalculateBmi(weight, height);
        }
    }
}
