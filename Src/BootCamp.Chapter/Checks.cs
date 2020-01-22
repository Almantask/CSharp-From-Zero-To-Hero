/*
 *                      ********This is a test class********
 * 
 * This class should not be changed. This tests each function for the BMI. I did
 * have to do a little cheating in looking at what this would look like, but eventually
 * I will self practice in how I think on TDD before creating a base project and running
 * it as to have full familiarity with TDD and how it helps in the long run with coding.
*/

using System;

namespace BootCamp.Chapter
{
    class checks
    {
        public static int GetIntegerPrompt(string message)
        {
            var result = Lesson3.GetInteger(message);

            return result;
        }

        public static float GetFloatPrompt(string message)
        {
            var result = Lesson3.GetFloat(message);

            return result;
        }

        public static string GetStringPrompt(string message)
        {
            var result = Lesson3.GetString(message);

            return result;
        }

        public static float GetFloatCalculation(float height, float weight)
        {
            var result = Lesson3.GetBMI(height, weight);

            return weight;
        }
    }
}
