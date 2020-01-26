using System;

namespace BootCamp.Chapter
{
    public static class Checks
    {
        public static int PromptInt(string message)
        {
            var answer = Lesson4.PromptInt(message);
            return answer;
        }

        public static string PromptString(string message)
        {
            var answer = Lesson4.PromptString(message);
            return answer;
        }

        public static float PromptFloat(string message)
        {
            var answer = Lesson4.PromptFloat(message);
            return answer;
        }

        public static float CalculateBmi(float weight, float height)
        {
            var answer = Lesson4.CalculateBmi(weight, height);
            return answer;
        }
    }
}
