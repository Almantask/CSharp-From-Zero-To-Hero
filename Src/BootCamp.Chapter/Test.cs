using System.Globalization;
using static BootCamp.Chapter.Settings;

namespace BootCamp.Chapter
{
    public static class Test
    {
        public static bool IsStringValid(string inputString)
        {
            return !string.IsNullOrEmpty(inputString) && !string.IsNullOrWhiteSpace(inputString);
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

        public static bool IsBalance(string[] balanace)
        {
            foreach (var amount in balanace)
            {
                if (!decimal.TryParse(amount, NumberStyles.Currency, cultureInfo, out _))
                {
                    return false;
                }
            }
            return true;
        }
    }
}