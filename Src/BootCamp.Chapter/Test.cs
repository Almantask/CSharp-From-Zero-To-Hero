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

        public static bool IsNumeric(string input)
        {
            return double.TryParse(input, out _);
        }

        public static bool IsName(string input)
        {
            string[] name = input.Split(' ');
            foreach (string item in name)
            {
                foreach (char character in item)
                {
                    if (!char.IsLetter(character))
                    {
                        return false;
                    }
                }
            }
            return true;
        }
    }
}