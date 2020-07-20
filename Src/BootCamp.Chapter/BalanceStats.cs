using System;
using System.Globalization;
using System.IO;
using System.Runtime.ExceptionServices;
using System.Text;

namespace BootCamp.Chapter
{
    public static class BalanceStats
    {
        /// <summary>
        /// Return name and balance(current) of person who had the biggest historic balance.
        /// </summary>

        private const string NotFound = "not found";

        public static string FindHighestBalanceEver(string balancesFile)
        {
            string balancesContent = ReturnFileContent(balancesFile);

            string[] peopleAndBalances = balancesContent.Split(Environment.NewLine);

            string personWithHighestBalanceEver = NotFound;
            double highestBalance = double.MinValue;


            foreach (string personInformation in peopleAndBalances)
            {
                string[] personInformationSplit = personInformation.Replace("£","").Split(",");

                const int FirstBalanceIndex = 1;

                for (int i = FirstBalanceIndex; i <= personInformationSplit.Length - 1; i++)
                {
                    bool isNumber = double.TryParse(personInformationSplit[i], out double balance);

                    if (!isNumber)
                    {
                        break;
                    }
                    else if (balance > highestBalance)
                    {
                        highestBalance = balance;
                        personWithHighestBalanceEver = $"{personInformationSplit[0]} (current balance: {personInformationSplit[^1]})";
                    }
                }

            }
            string informationOnHighestBalance = $"{personWithHighestBalanceEver} had the biggest historic balance: {highestBalance}";

            return informationOnHighestBalance;
        }

        private static string ReturnFileContent(string file)
        {
            if (String.IsNullOrEmpty(file)) throw new ArgumentException("Path to source file is empty");

            try
            {
                return File.ReadAllText(file);
            }
            catch (Exception ex)
            {
                throw new DirectoryNotFoundException("Path to source file does not exist", ex);
            }
        }

        /// <summary>
        /// Return name and loss of a person with a biggest loss (balance change negative).
        /// </summary>
        public static string FindPersonWithBiggestLoss(string[] peopleAndBalances)
        {
            string personWithBiggestLoss = NotFound;
            double biggestLoss = double.MinValue;

            foreach (string personInformation in peopleAndBalances)
            {
                string[] personInformationSplit = personInformation.Split(", ");

                const int FirstBalanceIndex = 1;

                for (int i = FirstBalanceIndex; i <= personInformationSplit.Length - 2; i++)
                {
                    bool isCurrentBalanceNumber = double.TryParse(personInformationSplit[i], out double previousBalance);
                    bool isNextBalanceNumber = double.TryParse(personInformationSplit[i + 1], out double nextBalance);

                    if (!isCurrentBalanceNumber || !isNextBalanceNumber)
                    {
                        break;
                    }
                    else if ((previousBalance - nextBalance) > biggestLoss)
                    {
                        biggestLoss = previousBalance - nextBalance;
                        personWithBiggestLoss = $"{personInformationSplit[0]}: {biggestLoss}";
                    }
                }

            }
            string informationOnBiggestLoss = $"The person with the biggest loss was: {personWithBiggestLoss}";

            return informationOnBiggestLoss;
        }

        /// <summary>
        /// Return name and current money of the richest person.
        /// </summary>
        public static string FindRichestPerson(string[] peopleAndBalances)
        {
            string richestPerson = NotFound;
            double highestCurrentBalance = double.MinValue;

            foreach (string personInformation in peopleAndBalances)
            {
                string[] personInformationSplit = personInformation.Split(", ");

                bool isLastBalanceANumber = double.TryParse(personInformationSplit[^1], out double currentBalance);

                if (!isLastBalanceANumber)
                {
                    break;
                }
                else if (currentBalance > highestCurrentBalance)
                {
                    highestCurrentBalance = currentBalance;
                    richestPerson = $"{personInformationSplit[0]} (current balance: {personInformationSplit[^1]})";
                }

            }

            string informationOnRichestPerson = $"Richest person currently is {richestPerson}";

            return informationOnRichestPerson;
        }

        /// <summary>
        /// Return name and current money of the most poor person.
        /// </summary>
        public static string FindMostPoorPerson(string[] peopleAndBalances)
        {
            string poorestPerson = NotFound;
            double lowestCurrentBalance = double.MaxValue;

            foreach (string personInformation in peopleAndBalances)
            {
                string[] personInformationSplit = personInformation.Split(", ");

                bool isLastBalanceANumber = double.TryParse(personInformationSplit[^1], out double currentBalance);

                if (!isLastBalanceANumber)
                {
                    break;
                }
                else if (currentBalance < lowestCurrentBalance)
                {
                    lowestCurrentBalance = currentBalance;
                    poorestPerson = $"{personInformationSplit[0]} (current balance: {personInformationSplit[^1]})";
                }

            }

            string informationOnPoorestPerson = $"Poorest person currently is {poorestPerson}";

            return informationOnPoorestPerson;
        }
    }
}
