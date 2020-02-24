using System.Globalization;

namespace BootCamp.Chapter
{
    public static class Test
    {
        public static bool IsStringValid(string inputString)
        {
            return !string.IsNullOrEmpty(inputString) && !string.IsNullOrWhiteSpace(inputString);
        }

        public static bool IsNumeric(string input)
        {
            return double.TryParse(input, out _);
        }

        public static bool IsName(string input)
        {
            const string validChars = "'-";

            string[] name = input.Split(' ');
            foreach (string item in name)
            {
                foreach (char character in item)
                {
                    if (!(char.IsLetter(character) || validChars.Contains(character)))
                    {
                        return false;
                    }
                }
            }
            return true;
        }

        public static bool IsBalance(string[] balanace, CultureInfo culture)
        {
            foreach (var amount in balanace)
            {
                if (!decimal.TryParse(amount, NumberStyles.Currency, culture, out _))
                {
                    return false;
                }
            }
            return true;
        }
    }
}