namespace UtilsLibrary
{
    public static class Utils
    {
        public static bool IsValid(string input)
        {
            return !string.IsNullOrWhiteSpace(input) || !string.IsNullOrEmpty(input);
        }

        public static bool IsValid(char input)
        {
            return char.IsLetterOrDigit(input);
        }
    }
}