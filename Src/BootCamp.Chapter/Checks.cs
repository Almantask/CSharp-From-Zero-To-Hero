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
            int convertedToInt = Lesson3.ConvertToInt(message);

            return convertedToInt;
            
        }

        public static string PromptString(string message)
        {
            
           string convertedToString = Lesson3.ConvertToString(message);

            return convertedToString;
        }

        public static float PromptFloat(string message)
        {
           float convertedToFloat = Lesson3.ConvertToFloat(message);

            return convertedToFloat;
        }

        public static float CalculateBmi(float weight, float height)
        {
           float convertedBmi = Lesson3.CalculateBmi(weight, height);

            return convertedBmi;
        }
    }
}
