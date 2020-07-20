using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;

namespace BootCamp.Chapter
{
    public static class FileCleaner
    {
        /// <summary>
        /// Cleans up dirtyFileName 
        /// </summary>
        /// <param name="dirtyFile">Dirty file with "_" placed in random places.</param>
        /// <param name="cleanedFile">Cleaned up file without any "_".</param>
        public static void Clean(string dirtyFile, string cleanedFile)
        {
            if (String.IsNullOrEmpty(dirtyFile)) throw new ArgumentException("Path to source file is empty");

            var contentToClean = new StringBuilder();

            try
            {
                contentToClean.Append(File.ReadAllText(dirtyFile));
            }
            catch (Exception ex)
            {
                throw new DirectoryNotFoundException("Path to source file does not exist", ex);
            }

            if (String.IsNullOrEmpty(contentToClean.ToString()))
            {
                File.WriteAllText(cleanedFile, contentToClean.ToString());
            }

            contentToClean.Replace("_", "");

            try
            {
                ValidateContent(contentToClean.ToString());
            }
            catch (Exception ex)
            {
                throw new InvalidBalancesException("Invalid Balances content", ex);
            }

            File.WriteAllText(cleanedFile, contentToClean.ToString());
        }

        private static void ValidateContent(string contentToValidate)
        {
            var differentPeople = contentToValidate.Split(Environment.NewLine);

            foreach (var person in differentPeople)
            {
                var nameAndBalances = person.Split(",");
                ValidateName(nameAndBalances[0]);
                if (nameAndBalances.Length > 1) ValidateBalances(nameAndBalances[1..^1]);
            }
        }

        private static void ValidateName(string name)
        {
            foreach (char letter  in name)
            {
                if (!(Char.IsLetter(letter) || letter.Equals(' ') || letter.Equals('\'') || letter.Equals('-')))
                {
                    throw new ArgumentException("Name contains invalid characters");
                }
            }
        }

        private static void ValidateBalances(string[] balances)
        {
            var moneyRegex = new Regex(@"-?£[0-9]{1,}.[0-9]{2}");

            foreach (string balance in balances)
            {
                if (!moneyRegex.IsMatch(balance))
                {
                    throw new ArgumentException("Balances are invalid");
                }
            }
        }
    }
}
