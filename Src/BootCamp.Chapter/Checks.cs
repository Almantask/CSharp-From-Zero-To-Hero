namespace BootCamp.Chapter
{
    class Checks
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
            var result = Lesson3.GetBmi(height, weight);

            return result;
        }
    }
}
