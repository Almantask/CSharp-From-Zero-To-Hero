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
            if (String.IsNullOrEmpty(pathToFile))
            {
                throw new ArgumentException("Path to source file is empty");
            }

            string content;
            try
            {
                content = File.ReadAllText(pathToFile);
            }
            catch (Exception ex)
            {
                throw new ArgumentException("Path to source file does not exist", ex);
            }

            if (!IsContentValid(content.ToString()))
            {
                content = Clean(content);
            }

            _content = content;

        }
        private static bool IsContentValid(string contentToValidate)
        {
            if (String.IsNullOrEmpty(contentToValidate)) return true;

            var differentPeople = contentToValidate.Split(Environment.NewLine);

            foreach (var person in differentPeople)
            {
                var nameAndBalances = person.Split(",");

                const int nameIndex = 0;
                if (!ISNameValid(nameAndBalances[nameIndex])) return false;

                const int firstBalanceIndex = 1;
                if (nameAndBalances.Length > firstBalanceIndex && !AreBalancesValid(nameAndBalances[firstBalanceIndex..^0])) return false;
                
            }

            return true;
        }

        private static bool ISNameValid(string name)
        {
            var nameRegex = new Regex(@"[a-zA-Z]+ [a-zA-Z]+'?-?[a-zA-Z]+[.]?$");
            var isMatch = nameRegex.IsMatch(name, 0);

            return isMatch;
        }

        private static bool AreBalancesValid(string[] balances)
        {
            var moneyRegex = new Regex(@"-?£[0-9]{1,}.[0-9]{2}$");

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

            if (!IsContentValid(contentToClean))
            {
                throw new InvalidBalancesException("Balances file is still invalid after cleaning up the file");
            }

            return contentToClean;
        }
    }
}
