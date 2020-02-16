namespace BootCamp.Chapter
{
    public static class Utils
    {
        public static int ConvertToInt(string input)
        {
            int.TryParse(input, out int value);
            return value;
        }

        public static bool IsNumeric(string input)
        {
            return int.TryParse(input, out _);
        }

        public static bool IsStringValid(string inputString)
        {
            return !string.IsNullOrEmpty(inputString) || !string.IsNullOrWhiteSpace(inputString);
        }
    }
}