using System;
using System.Text;
using System.Globalization;

namespace BootCamp.Chapter
{
    public static class BalanceStats
    {
        public static string[] allNames { get; private set; }
        public static float[][] allBalances { get; private set; }
        private static void ParsePeopleAndBalance(string[] peopleAndBalances)
        {
            CultureInfo.CurrentCulture = CultureInfo.InvariantCulture;
            allNames = new string[peopleAndBalances.Length];
            allBalances = new float[peopleAndBalances.Length][];
            for (int i = 0; i < peopleAndBalances.Length; i++)
            {
                string[] nameAndBalance = peopleAndBalances[i].Split(", ");
                allNames[i] = nameAndBalance[0];
                string[] balances = TrimArray(nameAndBalance[1..]);
                allBalances[i] = new float[balances.Length];
                for (int j = 0; j < balances.Length; j++)
                {
                    allBalances[i][j] = float.Parse(balances[j]);
                }
            }
        }

        /// <summary>
        /// Return name and balance(current) of person who had the biggest historic balance.
        /// </summary>
        public static string FindHighestBalanceEver(string[] peopleAndBalances)
        {
            CultureInfo culture = CultureInfo.CreateSpecificCulture("");
            culture.NumberFormat.CurrencyNegativePattern = 1;
            culture.NumberFormat.CurrencyGroupSeparator = "";
            if (peopleAndBalances == null || peopleAndBalances.Length == 0) { return "N/A."; }
            ParsePeopleAndBalance(peopleAndBalances);
            float highestBalance = GetHighestHistoricBalance();
            string[] names = GetPeopleOfHighestBalance(highestBalance);
            string namesStringResult = GetConcatenatedString(names);
            string formattedBalance = string.Format(culture, "{0:C0}", highestBalance);
            return $"{namesStringResult}had the most money ever. {formattedBalance}.";
        }

        // Helper method for finding the highest ever balance.
        private static float GetHighestHistoricBalance()
        {
            float highestBalance = allBalances[0][0];
            for (int i = 0; i < allBalances.Length; i++)
            {
                for (int j = 0; j < allBalances[i].Length; j++)
                {
                    if (allBalances[i][j] > highestBalance)
                    {
                        highestBalance = allBalances[i][j];
                    }
                }
            }
            return highestBalance;
        }

        // Helper method for populating a list of people with the highest balance recorded.
        private static string[] GetPeopleOfHighestBalance(float highestBalance)
        {
            string[] tempNames = new string[allNames.Length];
            int result = 0;
            for (int i = 0; i < allBalances.Length; i++)
            {
                for (int j = 0; j < allBalances[i].Length; j++)
                {
                    if (allBalances[i][j] == highestBalance)
                    {
                        tempNames[result] = allNames[i];
                        result++;
                        continue;
                    }
                }
            }
            return TrimArray(tempNames);
        }

        // Helper method for returning a new array without null elements.
        private static string[] TrimArray(string[] tempNames)
        {
            int numberOfElements = 0;
            foreach (var name in tempNames)
            {
                if (name != "" && name != null) { numberOfElements++; }
            }
            string[] trimmedArray = new string[numberOfElements];
            int index = 0;
            for (int i = 0; i < tempNames.Length; i++)
            {
                if (tempNames[i] != "" && tempNames[i] != null)
                {
                    trimmedArray[index] = tempNames[i];
                    index++;
                }
            }
            return trimmedArray;
        }

        // Helper method for constructing the correct name/names string.
        private static string GetConcatenatedString(string[] namesHighestBalance)
        {
            StringBuilder result = new StringBuilder();
            if (namesHighestBalance == null || namesHighestBalance.Length == 0) { return ""; }
            else if (namesHighestBalance.Length == 1) { return $"{namesHighestBalance[0]} "; }
            else
            {
                for (int i = 0; i < namesHighestBalance.Length - 1; i++)
                {
                    result.Append($"{namesHighestBalance[i]}, ");
                }
                result.Remove(result.Length - 2, 2);
                result.Append($" and {namesHighestBalance[^1] } ");
                return result.ToString();
            }
        }

        /// <summary>
        /// Return name and loss of a person with a biggest loss (balance change negative).
        /// </summary>
        public static string FindPersonWithBiggestLoss(string[] peopleAndBalances)
        {
            CultureInfo culture = CultureInfo.CreateSpecificCulture("");
            culture.NumberFormat.CurrencyNegativePattern = 1;
            culture.NumberFormat.CurrencyGroupSeparator = "";
            if (peopleAndBalances == null || peopleAndBalances.Length == 0) { return "N/A."; }
            ParsePeopleAndBalance(peopleAndBalances);
            float biggestLoss = GetBiggestLoss();
            if (biggestLoss == 0) { return "N/A."; }
            string name = GetNameOfBiggestLoss(biggestLoss);
            string formattedBalance = string.Format(culture, "{0:C0}", biggestLoss);
            return $"{name} lost the most money. {formattedBalance}.";
        }

        // Helper method to return the name of the person who has the biggest loss.
        private static string GetNameOfBiggestLoss(float biggestLoss)
        {
            string result = "";
            for (int i = 0; i < allBalances.Length; i++)
            {
                int index = 0;
                while (index != allBalances[i].Length - 1)
                {
                    if(allBalances[i][index + 1] - allBalances[i][index] == biggestLoss)
                    {
                        result = allNames[i];
                        break;
                    }
                    index++;
                }
            }
            return result;
        }

        // Helper method for finding the biggest loss ever.
        private static float GetBiggestLoss()
        {
            float biggestLoss = 0;
            for (int i = 0; i < allBalances.Length; i++)
            {
                float tempLoss = 0;
                int index = 0;
                while (index != allBalances[i].Length - 1)
                {
                    tempLoss = allBalances[i][index + 1] - allBalances[i][index];
                    if (tempLoss < biggestLoss) { biggestLoss = tempLoss; }
                    index++;
                }
            }
            return biggestLoss;
        }

        /// <summary>
        /// Return name and current money of the richest person.
        /// </summary>
        public static string FindRichestPerson(string[] peopleAndBalances)
        {
            CultureInfo culture = CultureInfo.CreateSpecificCulture("");
            culture.NumberFormat.CurrencyNegativePattern = 1;
            culture.NumberFormat.CurrencyGroupSeparator = "";
            if (peopleAndBalances == null || peopleAndBalances.Length == 0) { return "N/A."; }
            ParsePeopleAndBalance(peopleAndBalances);
            float highestCurrentBalance = GetHighestCurrentBalance();
            string[] names = GetPeopleOfBalance(highestCurrentBalance);
            string namesStringResult = GetConcatenatedString(names);
            string formattedBalance = string.Format(culture, "{0:C0}", highestCurrentBalance);
            if (names.Length > 1) { return $"{namesStringResult}are the richest people. {formattedBalance}."; }
            else return $"{namesStringResult}is the richest person. {formattedBalance}.";
        }
        
        // Helper method to get every person with wanted current balance.
        private static string[] GetPeopleOfBalance(float balance)
        {
            string[] tempNames = new string[allNames.Length];
            int result = 0;
            for (int i = 0; i < allBalances.Length; i++)
            {
                if(allBalances[i][^1] == balance)
                {
                    tempNames[result] = allNames[i];
                    result++;
                }
            }
            return TrimArray(tempNames);
        }

        // Helper method to get the highest current balance.
        private static float GetHighestCurrentBalance()
        {
            float highestCurrentBalance = allBalances[0][^1];
            for (int i = 0; i < allBalances.Length; i++)
            {
                if(allBalances[i][^1] > highestCurrentBalance) { highestCurrentBalance = allBalances[i][^1]; }
            }
            return highestCurrentBalance;
        }

        /// <summary>
        /// Return name and current money of the most poor person.
        /// </summary>
        public static string FindMostPoorPerson(string[] peopleAndBalances)
        {
            CultureInfo culture = CultureInfo.CreateSpecificCulture("");
            culture.NumberFormat.CurrencyNegativePattern = 1;
            culture.NumberFormat.CurrencyGroupSeparator = "";
            if (peopleAndBalances == null || peopleAndBalances.Length == 0) { return "N/A."; }
            ParsePeopleAndBalance(peopleAndBalances);
            float lowestCurrentBalance = GetLowestCurrentBalance();
            string[] names = GetPeopleOfBalance(lowestCurrentBalance);
            string namesStringResult = GetConcatenatedString(names);
            string formattedBalance = string.Format(culture, "{0:C0}", lowestCurrentBalance);
            if (names.Length > 1) { return $"{namesStringResult}have the least money. {formattedBalance}."; }
            else return $"{namesStringResult}has the least money. {formattedBalance}.";
        }

        // Helper method to return the lowest current balance.
        private static float GetLowestCurrentBalance()
        {
            float lowestCurrentBalance = allBalances[0][^1];
            for (int i = 0; i < allBalances.Length; i++)
            {
                if (allBalances[i][^1] < lowestCurrentBalance) { lowestCurrentBalance = allBalances[i][^1]; }
            }
            return lowestCurrentBalance;
        }

    }
}
