using System;
using System.IO;
using System.Globalization;

namespace BootCamp.Chapter
{
    class FileUtilities
    {
        /// <summary>
        /// Makes the content of a file parsable by replacing all occurences of a specific string in its contents and returns the outcome as an array of strings.
        /// </summary>
        /// <param name="inputFilePath">The path of the file which needs to be made parsable.</param>
        /// <param name="stringToReplace">The string whose all occurences will be replaced in the file.</param>
        /// <returns></returns>
        public static string[] MakeContentParsable(string inputFilePath, string stringToReplace)
        {
            if (File.Exists(inputFilePath))
            {
                var inputLines = File.ReadAllLines(inputFilePath);
                var parsableLines = new string[inputLines.Length];

                for (int i = 0; i < inputLines.Length; i++)
                {
                    var parsableLine = inputLines[i].Replace(stringToReplace, "");
                    parsableLines[i] = parsableLine;
                }

                return parsableLines;
            }

            return new string[] { "" };
        }

        /// <summary>
        /// Validates a file by checking whether it contains valid names and/or balances.
        /// </summary>
        /// <param name="inputFilePath">The file to be validated.</param>
        /// <param name="cultureLocale">The CultureInfo object that deteremines the currency type that will be used as part of the validation.</param>
        public static void ValidateFile(string inputFilePath, CultureInfo cultureLocale)
        {
            if (File.Exists(inputFilePath))
            {
                var inputLines = File.ReadAllLines(inputFilePath);

                for (int i = 0; i < inputLines.Length; i++)
                {
                    var currentLine = inputLines[i].Split(',');
                    ValidateName(currentLine[0]); // We parse only names which sit at index 0
                    ValidateBalances(currentLine[1..], cultureLocale); // We parse all values except for names which sit at index 0
                }
            }
        }

        /// <summary>
        /// Validates a string by checking whether it contains letters and allowed special characters only. If not, then it throws an exception.
        /// </summary>
        /// <param name="name">The string which needs validation.</param>
        private static void ValidateName(string name)
        {
            var allowedSpecialCharacters = new[] { " ", "'", "-" };

            foreach (var character in name)
            {
                var isValid = Char.IsLetter(character) || IsAllowedCharacter(character, allowedSpecialCharacters);
                if (!isValid) throw new InvalidBalancesException($"{name} is not a valid name.");
            }        
        }

        /// <summary>
        /// Checks whether it can parse elements into decimals from a given array of strings. If not, then it throws an InvalidBalancesException.
        /// </summary>
        /// <param name="inputArray">The array whose elements will be iterated through and parsed.</param>
        /// <param name="cultureLocale">The specific CultureInfo object against which the array elements will be parsed.</param>
        private static void ValidateBalances(string[] inputArray, CultureInfo cultureLocale)
        {
            foreach (var value in inputArray)
            {
                try
                {
                    decimal.Parse(value, NumberStyles.Currency, cultureLocale);
                }
                catch (Exception ex)
                {
                    throw new InvalidBalancesException($"{value} cannot be parsed", ex);
                }
            }
        }

        /// <summary>
        /// Checks whether a given character is part of a list of allowed characters or not. Returns true if it is, otherwise false.
        /// </summary>
        /// <param name="character">The character that needs to be checked against an array of allowed characters.</param>
        /// <param name="allowedCharacters">The array of characters that are allowed/whitelisted.</param>
        /// <returns></returns>
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
