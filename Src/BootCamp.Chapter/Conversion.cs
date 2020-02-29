using System.Globalization;

namespace BootCamp.Chapter
{
    public static class Conversion
    {
        public static decimal ToDecimal(string input)
        {
            decimal.TryParse(input, NumberStyles.Currency, Settings.numberFormatInfo, out decimal value);
            return value;
        }
    }
}