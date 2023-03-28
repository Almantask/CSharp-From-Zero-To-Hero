using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;

namespace BootCamp.Chapter
{
    // This class is used to have a freedom of design, but with tests applied.
    public static class Checks
    {
        public static string FindMostPoorPerson(string[] peopleAndBalances)
        {
            if ((peopleAndBalances?.Length > 0) == false)
            {
                return "N/A.";
            }

            float lowestBalance = 0;
            var peopleWithLowestBalance = Array.Empty<string>();

            for (int i = 0; i < peopleAndBalances.Length; i++)
            {
                string person = peopleAndBalances[i].Split(", ")[0];
                float balance = float.Parse(peopleAndBalances[i].Split(", ")[^1]);
                if (i == 0)
                {
                    lowestBalance = balance;
                }

                if (balance < lowestBalance)
                {
                    peopleWithLowestBalance = new string[1];
                    peopleWithLowestBalance[0] = person;
                    lowestBalance = balance;
                }
                else if (balance == lowestBalance)
                {
                    Array.Resize(ref peopleWithLowestBalance, peopleWithLowestBalance.Length + 1);
                    peopleWithLowestBalance[^1] = person;
                }
            }

            string peopleFormatted = FormatListOfPeople(peopleWithLowestBalance);

            string toBeConjugation = peopleWithLowestBalance.Length > 1 ? "have" : "has";
            string currencyFormatted = FormatCurrency(lowestBalance);

            return $"{peopleFormatted} {toBeConjugation} the least money. {currencyFormatted}.";
        }

        public static string FindRichestPerson(string[] peopleAndBalances)
        {
            if ((peopleAndBalances?.Length > 0) == false)
            {
                return "N/A.";
            }

            var peopleWithHighestBalance = Array.Empty<string>();
            float highestBalance = 0;
            foreach (var line in peopleAndBalances)
            {
                string person = line.Split(", ")[0];
                float balance = float.Parse(line.Split(", ")[^1]);

                if (balance > highestBalance)
                {
                    peopleWithHighestBalance = new string[1];
                    peopleWithHighestBalance[0] = person;
                    highestBalance = balance;
                }
                else if (balance == highestBalance)
                {
                    Array.Resize(ref peopleWithHighestBalance, peopleWithHighestBalance.Length + 1);
                    peopleWithHighestBalance[^1] = person;
                }
            }

            string peopleFormatted = FormatListOfPeople(peopleWithHighestBalance);

            string toBeConjugation = peopleWithHighestBalance.Length > 1 ? "are" : "is";
            string personNouns = peopleWithHighestBalance.Length > 1 ? "people" : "person";

            return $"{peopleFormatted} {toBeConjugation} the richest {personNouns}. ¤{highestBalance}.";
        }

        public static string FindPersonWithBiggestLoss(string[] peopleAndBalances)
        {
            if ((peopleAndBalances?.Length > 0) == false)
            {
                return "N/A.";
            }

            // These only have 1 entry in the balances.
            if (peopleAndBalances[0].Split(", ").Length <= 2)
            {
                return "N/A.";
            }

            float biggestLoss = 0;
            var peopleWithBiggestLoss = Array.Empty<string>();
            for (int i = 0; i < peopleAndBalances.Length; i++)
            {
                string person = peopleAndBalances[i].Split(", ")[0];
                string[] balances = peopleAndBalances[i].Split(", ")[1..];

                for (int j = 0; j < balances.Length - 1; j++)
                {
                    float loss = float.Parse(balances[j + 1]) - float.Parse(balances[j]);

                    if (j == 0)
                    {
                        biggestLoss = loss;
                    }

                    if (loss < biggestLoss)
                    {
                        peopleWithBiggestLoss = new string[1];
                        peopleWithBiggestLoss[0] = person;
                        biggestLoss = loss;
                    }
                    else if (loss == biggestLoss)
                    {
                        Array.Resize(ref peopleWithBiggestLoss, peopleWithBiggestLoss.Length + 1);
                        peopleWithBiggestLoss[^1] = person;
                    }
                }

                string peopleFormatted = FormatListOfPeople(peopleWithBiggestLoss);

                string currencyFormatted = FormatCurrency(biggestLoss);

                return $"{peopleFormatted} lost the most money. {currencyFormatted}.";
            }

            return "";
        }

        private static string FormatCurrency(float amount)
        {
            string currencySymbol = amount >= 0 ? "¤" : "-¤";

            return $"{currencySymbol}{Math.Abs(amount)}";
        }

        public static string FindHighestBalanceEver(string[] peopleAndBalances)
        {
            if ((peopleAndBalances?.Length > 0) == false)
            {
                return "N/A.";
            }

            float highestBalance = 0;

            // Can't predict how many people will have the highest balance ahead of time
            var peopleWithHighestBalance = Array.Empty<string>();

            foreach (var line in peopleAndBalances)
            {
                string person = line.Split(", ")[0];
                string[] balances = line.Split(", ")[1..];

                foreach (var balance in balances)
                {
                    float currentBalance = float.Parse(balance);
                    if (currentBalance > highestBalance)
                    {
                        peopleWithHighestBalance = new string[1];
                        peopleWithHighestBalance[0] = person;
                        highestBalance = currentBalance;
                    }
                    else if (currentBalance == highestBalance)
                    {
                        Array.Resize(ref peopleWithHighestBalance, peopleWithHighestBalance.Length + 1);
                        peopleWithHighestBalance[^1] = person;
                    }
                }
            }

            string peopleFormatted = FormatListOfPeople(peopleWithHighestBalance);

            return $"{peopleFormatted} had the most money ever. ¤{highestBalance}.";
        }

        private static string FormatListOfPeople(string[] people)
        {
            string peopleFormatted = "";
            for (int i = 0; i < people.Length; i++)
            {
                if (i == 0)
                {
                    peopleFormatted = people[i];
                }
                else if (i == people.Length - 1)
                {
                    peopleFormatted += $" and {people[i]}";
                }
                else
                {
                    peopleFormatted += $", {people[i]}";
                }
            }

            return peopleFormatted;
        }

        public static string Build(string message, in int padding)
        {
            if (string.IsNullOrEmpty(message))
            {
                return "";
            }

            string[] messageLines = message.Split(Environment.NewLine);

            int longestLineLength = GetLongestLineLength(messageLines);
            int linePaddingLength = longestLineLength + (padding * 2) + 1;

            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"{"+".PadRight(linePaddingLength, '-')}+");

            sb.Append(GetTopOrBottomPaddingLines(padding, linePaddingLength));

            foreach (string line in messageLines)
            {
                sb.AppendLine($"{"|".PadRight(padding + 1)}{line.PadRight(longestLineLength)}{"|".PadLeft(padding + 1)}");
            }

            sb.Append(GetTopOrBottomPaddingLines(padding, linePaddingLength));

            sb.AppendLine($"{"+".PadRight(linePaddingLength, '-')}+");


            return sb.ToString();
        }

        private static string GetTopOrBottomPaddingLines(int padding, int linePaddingLength)
        {
            var sb = new StringBuilder();

            for (int i = 0; i < padding; i++)
            {
                sb.AppendLine($"{"|".PadRight(linePaddingLength)}|");
            }

            return sb.ToString();
        }

        private static int GetLongestLineLength(string[] messageLines)
        {
            int longestMessageLength = 0;
            foreach (string line in messageLines)
            {
                if (line.Length > longestMessageLength)
                {
                    longestMessageLength = line.Length;
                }
            }

            return longestMessageLength;
        }

        public static void Clean(string file, string outputFile)
        {
            if (!File.Exists(file))
            {
                throw new ArgumentException();
            }

            var fileContents = File.ReadAllText(file);
            fileContents = fileContents.Replace("_", "");
            var lines = fileContents.Split(Environment.NewLine);

            foreach (var line in lines)
            {
                var columns = line.Split(',');

                var name = columns[0];

                var regex = new Regex("^[A-Za-z-\' ]*.?$");
                if (!regex.IsMatch(name))
                {
                    throw new InvalidBalancesException("Not a valid name", null);
                }

                foreach (var balance in columns[1..])
                {
                    if (decimal.TryParse(balance.Replace("£", ""), out var amount) == false)
                    {
                        throw new InvalidBalancesException("Not a valid number", null);
                    }
                }
            }

            File.WriteAllText(outputFile, fileContents);
        }
    }
}
