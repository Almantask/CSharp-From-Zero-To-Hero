namespace BootCamp.Chapter
{
    public static class StringOps
    {
        public static bool IsStringValid(string message)
        {
            return !string.IsNullOrWhiteSpace(message) || !string.IsNullOrEmpty(message);
        }
    }
}