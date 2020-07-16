using System.Globalization;

namespace BootCamp.Chapter
{
    public static class BalanceStats
    {
        /// <summary>
        /// Return name and balance(current) of person who had the biggest historic balance.
        /// </summary>
        public static string FindHighestBalanceEver(string[] peopleAndBalances)
        {
            string personWithHighestBalanceEver = "not found";
            double? highestBalance = null;

            foreach (string personInformation in peopleAndBalances)
            {
                string[] personInformationSplit = personInformation.Split(", ");

                for (int i = 1; i <= personInformationSplit.Length - 1; i++)
                {
                    bool isNumber = double.TryParse(personInformationSplit[i], out double balance);

                    if (!isNumber)
                    {
                        break;
                    }
                    else if (highestBalance == null || balance > highestBalance)
                    {
                        highestBalance = balance;
                        personWithHighestBalanceEver = $"{personInformationSplit[0]} (current balance: {personInformationSplit[^1]})";
                    }
                }

            }
            string informationOnHighestBalance = $"{personWithHighestBalanceEver} had the biggest historic balance";

            return informationOnHighestBalance;
        }

        /// <summary>
        /// Return name and loss of a person with a biggest loss (balance change negative).
        /// </summary>
        public static string FindPersonWithBiggestLoss(string[] peopleAndBalances)
        {
            string personWithBiggestLoss = "not found";
            double? biggestLoss = null;

            foreach (string personInformation in peopleAndBalances)
            {
                string[] personInformationSplit = personInformation.Split(", ");

                for (int i = 1; i <= personInformationSplit.Length - 2; i++)
                {
                    bool isPreviousBalanceNumber = double.TryParse(personInformationSplit[i], out double previousBalance);
                    bool isNextBalanceNumber = double.TryParse(personInformationSplit[i+1], out double nextBalance);

                    if (!isPreviousBalanceNumber || !isNextBalanceNumber)
                    {
                        break;
                    }
                    else if (biggestLoss == null || (previousBalance - nextBalance) > biggestLoss)
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
            string richestPerson = "not found";
            double? highestCurrentBalance = null;

            foreach (string personInformation in peopleAndBalances)
            {
                string[] personInformationSplit = personInformation.Split(", ");

                bool isLastBalanceANumber = double.TryParse(personInformationSplit[^1], out double currentBalance);

                if (!isLastBalanceANumber)
                {
                    break;
                }
                else if (highestCurrentBalance == null || currentBalance > highestCurrentBalance)
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
            string poorestPerson = "not found";
            double? lowestCurrentBalance = null;

            foreach (string personInformation in peopleAndBalances)
            {
                string[] personInformationSplit = personInformation.Split(", ");

                bool isLastBalanceANumber = double.TryParse(personInformationSplit[^1], out double currentBalance);

                if (!isLastBalanceANumber)
                {
                    break;
                }
                else if (lowestCurrentBalance == null || currentBalance < lowestCurrentBalance)
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
