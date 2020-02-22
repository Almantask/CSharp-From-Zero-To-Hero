using System.Globalization;

namespace BootCamp.Chapter
{
    public static class Test
    {
        private static readonly NumberFormatInfo numberFormatInfo = new NumberFormatInfo { NumberDecimalSeparator = "." };

        public static bool IsStringValid(string inputString)
        {
            return !string.IsNullOrEmpty(inputString) && !string.IsNullOrWhiteSpace(inputString);
        }

        public static decimal ConvertToDecimal(string input)
        {
            decimal.TryParse(input, NumberStyles.Currency, numberFormatInfo, out decimal value);

            return value;
        }
    }
}