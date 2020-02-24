using System.Globalization;

namespace BootCamp.Chapter
{
    public static class Conversion
    {
        public static decimal ConvertToDecimal(string input)
        {
            decimal.TryParse(input, NumberStyles.Currency, Settings.numberFormatInfo, out decimal value);
            return value;
        }
    }
}