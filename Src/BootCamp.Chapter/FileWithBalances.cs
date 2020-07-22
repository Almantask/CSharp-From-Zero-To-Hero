using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace BootCamp.Chapter
{
    class FileWithBalances
    {
        private readonly string _content;

        public string GetContent()
        {
            return _content;
        }

        public FileWithBalances(string pathToFile)
        {
            if (String.IsNullOrEmpty(pathToFile)) throw new ArgumentException("Path to source file is empty");

            string content = "";
            try
            {
                content = File.ReadAllText(pathToFile);
            }
            catch (Exception ex)
            {
                throw new DirectoryNotFoundException("Path to source file does not exist", ex);
            }

            if (!IsContentValid(content.ToString())) content = Clean(content) ;

            _content = content;

        }
        private static bool IsContentValid(string contentToValidate)
        {
            
            var differentPeople = contentToValidate.Split(Environment.NewLine);

            foreach (var person in differentPeople)
            {
                var nameAndBalances = person.Split(",");
                if (!ISNameValid(nameAndBalances[0])) return false;
                if (nameAndBalances.Length > 1 && !AreBalancesValid(nameAndBalances[1..^1])) return false;
                
            }

            return true;
        }

        private static bool ISNameValid(string name)
        {
            foreach (char letter in name)
            {
                if (!(Char.IsLetter(letter) || letter.Equals(' ') || letter.Equals('\'') || letter.Equals('-') || letter.Equals('.')))
                {
                    return false;
                }
            }

            return true;
        }

        private static bool AreBalancesValid(string[] balances)
        {
            var moneyRegex = new Regex(@"-?£[0-9]{1,}.[0-9]{2}");

            foreach (string balance in balances)
            {
                if (!moneyRegex.IsMatch(balance))
                {
                    return false;
                }
            }

            return true;
        }

        private static string Clean(string content)
        {
            var contentToClean = content;
            contentToClean = contentToClean.Replace("_", "");

            if (!IsContentValid(contentToClean)) throw new InvalidBalancesException("Balances file is still invalid after cleaning up the file");

            return contentToClean;
        }
    }
}
