using System.Globalization;

namespace BootCamp.Chapter
{
    public static class Settings
    {
        public static readonly NumberFormatInfo numberFormatInfo = new NumberFormatInfo { NumberDecimalSeparator = "." };
        public static readonly CultureInfo cultureInfo = new CultureInfo("en-GB");
        public static readonly char divider = ',';
        public static readonly string currency = "\u00A4";
        public static readonly string corruptionChar = "_";
        public static readonly string emptyChar = "";
    }
}