using System;
using System.Collections.Generic;
using System.Text;

namespace BootCamp.Chapter
{
    public static class Checks
    {
        public static int PromptInt(string message)
        {
            return Lesson3.InputInteger(message);
        }

        public static string PromptString(string message)
        {
            return Lesson3.InputName(message);
        }

        public static float PromptFloat(string message)
        {
            return Lesson3.InputFloat(message);
        }

        public static float CalculateBmi(float weight, float height)
        {
            return Lesson3.CalculateBodyMassIndex(weight, height);
        }
    }
}
