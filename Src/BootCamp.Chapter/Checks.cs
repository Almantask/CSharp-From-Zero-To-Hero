using System;
using System.Collections.Generic;
using System.Text;

namespace BootCamp.Chapter
{
    namespace BootCamp.Chapter
{

    public static class Checks
    {
        public static int PromptInt(string message)
        {

            return Lesson3.PromptInteger(message);
        }

        public static string PromptString(string message)
        {


            return Lesson3.PromptString(message);
        }

        public static float PromptFloat(string message)
        {

            return Lesson3.PromptFloat(message);
        }

        public static float CalculateBmi(float weight, float height)
        {

            return Lesson3.CalculateBmi(weight, height);
        }
    }
}
}