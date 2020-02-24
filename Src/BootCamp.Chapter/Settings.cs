using System.Globalization;

namespace BootCamp.Chapter
{
    public static class Settings
    {
        public static NumberFormatInfo numberFormatInfo = new NumberFormatInfo { NumberDecimalSeparator = "." };
        public static CultureInfo cultureInfo = new CultureInfo("en-GB");
        public static char divider = ',';
        public static string currency = "\u00A4";
        public static string corruptionChar = "_";
        public static string emptyChar = "";
    }
}