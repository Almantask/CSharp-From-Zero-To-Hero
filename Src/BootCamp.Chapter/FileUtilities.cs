using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Globalization;

namespace BootCamp.Chapter
{
    class FileUtilities
    {
        public static void ValidateFile(string inputFilePath, CultureInfo cultureLocale)
        {
            if (File.Exists(inputFilePath))
            {
                var inputLines = File.ReadAllLines(inputFilePath);

                for (int i = 0; i < inputLines.Length; i++)
                {
                    var currentLine = inputLines[i].Split(',');
                    ValidateName(currentLine[0]);

                    foreach (var entry in currentLine[1..])
                    {
                        try
                        {
                            decimal.Parse(entry, NumberStyles.Currency, cultureLocale);
                        }
                        catch (Exception ex)
                        {
                            throw new InvalidBalancesException($"{entry} cannot be parsed", ex);
                        }
                    }
                }
            }
        }

        private static void ValidateName(string name)
        {
            var allowedSpecialCharacters = new[] { " ", "'", "-" };

            foreach (var character in name)
            {
                var isValid = Char.IsLetter(character) || IsAllowedCharacter(character, allowedSpecialCharacters);
                if (!isValid) throw new InvalidBalancesException($"{name} is not a valid name.");
            }        
        }

        private static bool IsAllowedCharacter(char character, string[] allowedCharacters)
        {
            foreach (var element in allowedCharacters)
            {
                if (character.ToString() == element)
                {
                    return true;
                }
            }

            return false;
        }
    }
}
