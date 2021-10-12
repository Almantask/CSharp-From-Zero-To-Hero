using System;
using System.Globalization;
using System.Text;

namespace BootCamp.Chapter
{
    public static class BalanceStats
    { 
        /// <summary>
        /// Return name and balance(current) of person who had the biggest historic balance.
        /// </summary>
        public static string FindHighestBalanceEver(string[] peopleAndBalances)
        {
            string highestBalanceName = string.Empty;
            string currentBalanceS = string.Empty;
            double higestBalanceValue = default;
            double currentValue;
            bool isHighestBalance = false;

            for (int i = 0; i < peopleAndBalances.Length; i++)
            {
                var currPersonData = peopleAndBalances[i].Split(',');
                for (int j = 0; j < currPersonData.Length; j++)
                {
                    bool success = double.TryParse(currPersonData[j], out currentValue);
                    if (success)
                    {
                        var tmpValue = currentValue;
                        if (tmpValue > higestBalanceValue)
                        {
                            higestBalanceValue = tmpValue;
                            highestBalanceName = currPersonData[0];
                            isHighestBalance = true;
                        }
                    }
                }
                if (isHighestBalance) currentBalanceS = currPersonData[^1].Substring(0);
                isHighestBalance = false;
            }

            CultureInfo.CurrentCulture = CultureInfo.InvariantCulture;
            decimal currentBalanceStoDecimal = Convert.ToDecimal(currentBalanceS);
            string currentBalanceDecimal = $"{currentBalanceStoDecimal:C0}";

            return $"{highestBalanceName} had the most money ever. {currentBalanceDecimal}.";
        }

        /// <summary>
        /// Return name and loss of a person with a biggest loss (balance change negative).
        /// </summary>
        public static string FindPersonWithBiggestLoss(string[] peopleAndBalances)
        {
            string highestBalanceName = string.Empty;
            string currentBalanceS = string.Empty;
            double higestLossValue = default;
            double currentValue;
            bool isHighestLoss = false;

            for (int i = 0; i < peopleAndBalances.Length; i++)
            {
                var currPersonData = peopleAndBalances[i].Split(',');
                for (int j = 0; j < currPersonData.Length; j++)
                {
                    bool success = double.TryParse(currPersonData[j], out currentValue);
                    if (success)
                    {
                        var tmpValue = currentValue;
                        if (tmpValue > double.Parse(currPersonData[j+1]))
                        {
                            higestLossValue = double.Parse(currPersonData[j+1]) - tmpValue;
                            highestBalanceName = currPersonData[0];
                            isHighestLoss = true;
                        }
                    }
                }
                if (isHighestLoss) currentBalanceS = higestLossValue.ToString();
                isHighestLoss = false;
            }

            Console.WriteLine(highestBalanceName + currentBalanceS);

            return highestBalanceName + currentBalanceS;
        }

        /// <summary>
        /// Return name and current money of the richest person.
        /// </summary>
        public static string FindRichestPerson(string[] peopleAndBalances)
        {
            string highestBalanceName = string.Empty;
            string currentBalanceS = string.Empty;
            double higestBalanceValue = default;
            double currentValue;
            bool isHighestBalance = false;

            for (int i = 0; i < peopleAndBalances.Length; i++)
            {
                var currPersonData = peopleAndBalances[i].Split(',');
                for (int j = currPersonData.Length - 1; j < currPersonData.Length; j++)
                {
                    bool success = double.TryParse(currPersonData[j], out currentValue);
                    if (success)
                    {
                        var tmpValue = currentValue;
                        if (tmpValue > higestBalanceValue)
                        {
                            higestBalanceValue = tmpValue;
                            highestBalanceName = currPersonData[0];
                            isHighestBalance = true;
                        }
                    }
                }
                if (isHighestBalance) currentBalanceS = currPersonData[^1].Substring(0);
                isHighestBalance = false;
            }

            //Console.WriteLine(highestBalanceName + currentBalanceS);
            CultureInfo.CurrentCulture = CultureInfo.InvariantCulture;
            decimal currentBalanceStoDecimal = Convert.ToDecimal(currentBalanceS);
            string currentBalanceDecimal = $"{currentBalanceStoDecimal:C0}";

            return $"{highestBalanceName} is the richest person. {currentBalanceDecimal:C0}.";
        }

        /// <summary>
        /// Return name and current money of the most poor person.
        /// </summary>
        public static string FindMostPoorPerson(string[] peopleAndBalances)
        {
            string lowestBalanceName = string.Empty;
            string currentBalanceS = string.Empty;
            double currentValue;
            bool isLowestBalance = false;
            var tmpValue = double.MaxValue;

            for (int i = 0; i < peopleAndBalances.Length; i++)
            {
                var currPersonData = peopleAndBalances[i].Split(',');
                for (int j = currPersonData.Length - 1; j < currPersonData.Length; j++)
                {
                    bool success = double.TryParse(currPersonData[j], out currentValue);
                    if (success)
                    {
                        if (currentValue < tmpValue)
                        {
                            tmpValue = currentValue;
                            lowestBalanceName = currPersonData[0];
                            isLowestBalance = true;
                        }
                    }
                }
                if (isLowestBalance) currentBalanceS = currPersonData[^1].Substring(0);
                isLowestBalance = false;
            }

            //Console.WriteLine(lowestBalanceName + currentBalanceS);
            CultureInfo.CurrentCulture = CultureInfo.InvariantCulture;
            decimal currentBalanceStoDecimal = Convert.ToDecimal(currentBalanceS);
            string currentBalanceDecimal = $"{currentBalanceStoDecimal:C0}";

            return $"{lowestBalanceName} has the least money. {currentBalanceDecimal:C0}.";
        }
    }
}
