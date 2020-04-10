using System;
using System.Collections.Generic;
using System.Text;

namespace BootCamp.Chapter
{
    public static class Checks
    {
        public static int PromptInt(string message)
        {
            return Lesson4.GetInt(message);
        }

        public static string PromptString(string message)
        { 
            return Lesson4.GetString(message);
        }

        public static float PromptFloat(string message)
        {
            return Lesson4.GetFloat(message);
        }

        public static float CalculateBmi(float weight, float height)
        {
            return 0;
        }
    }
}
