namespace BootCamp.Chapter
{
    public static class Util
    {
        public static bool IsNumeric(string s)
        {
            return double.TryParse(s, out _);
        }
    }
}