using System;
using System.Globalization;
using System.Threading;
using static System.FormattableString;


namespace BootCamp.Chapter
{
    public static class BalanceStats
    {
        
        /// <summary>
        /// Return name and balance(current) of person who had the biggest historic balance.
        /// </summary>
        public static string FindHighestBalanceEver(string[] peopleAndBalances)
        {
            if (peopleAndBalances == null || peopleAndBalances.Length == 0)
            {
                return "N/A.";
            }

            double highestBalance = double.MinValue;
            string highestBalanceHolder = "";
            int holderCount = 0;

            foreach (string entry in peopleAndBalances)
            {
                string[] userNameAndBalanceHistory = entry.Split(',');
                string currentBalanceHolder = userNameAndBalanceHistory[0];

                for (int i = 1; i < userNameAndBalanceHistory.Length; i++)
                {
                    double balance;
                    try
                    {
                        balance = double.Parse(userNameAndBalanceHistory[i]);
                    }
                    catch
                    {
                        balance = 0;
                    }
                    if (balance > highestBalance)
                    {
                        highestBalanceHolder = currentBalanceHolder;
                        holderCount = 1;
                    }
                    if (balance == highestBalance)
                    {
                        if (holderCount == 2)
                        {
                            highestBalanceHolder += ($" and {currentBalanceHolder}");
                        }
                        if (holderCount == 1)
                        {
                            highestBalanceHolder += ($", {currentBalanceHolder}");
                            holderCount++;
                        }
                    }
                    highestBalance = highestBalance < balance ? balance : highestBalance;
                }
            }
            string stringHighestBalance = highestBalance.ToString();
            return Invariant($"{highestBalanceHolder} had the most money ever. ¤{stringHighestBalance}.");
        }

        /// <summary>
        /// Return name and loss of a person with a biggest loss (balance change negative).
        /// </summary>
        public static string FindPersonWithBiggestLoss(string[] peopleAndBalances)
        {
            double biggestLoss = 0;
            double balance;
            double nextBalance;
            string biggestLoser = "";
            int holderCount = 0;
            if (peopleAndBalances == null || peopleAndBalances.Length == 0)
            {
                return "N/A.";
            }
            foreach (string entry in peopleAndBalances)
            {
                string[] userHistory = entry.Split(',');

                if (userHistory.Length <= 2)
                {
                    return "N/A.";
                }

                string currentBalanceHolder = userHistory[0];

                for (int i = 1; i < userHistory.Length - 1; i++)
                {
                    balance = double.TryParse(userHistory[i], out double result) ?
                        double.Parse(userHistory[i]) : double.NaN;

                    nextBalance = double.TryParse(userHistory[i + 1], out double nextResult) ?
                        double.Parse(userHistory[i + 1]) : double.NaN;

                    if ((nextBalance - balance) < biggestLoss)
                    {
                        biggestLoser = currentBalanceHolder;
                        holderCount = 1;
                    }

                    if (biggestLoss == nextBalance - balance)
                    {
                        if ( holderCount > 1)
                        {
                            biggestLoser += ($" and {currentBalanceHolder}");
                        }
                        if (holderCount == 1)
                        {
                            biggestLoser += ($", {currentBalanceHolder}");
                            holderCount++;
                        }
                    }
                    biggestLoss = ((nextBalance - balance) < biggestLoss) ?
                        (nextBalance - balance) : biggestLoss;
                }
            }
            string stringBiggestLoss = Math.Abs(biggestLoss).ToString();
            return Invariant($"{biggestLoser} lost the most money. -¤{stringBiggestLoss}.");
        }
        /// <summary>
        /// Return name and current money of the richest person.
        /// </summary>
        public static string FindRichestPerson(string[] peopleAndBalances)
        {
            if (peopleAndBalances == null || peopleAndBalances.Length == 0)
            {
                return "N/A.";
            }
            int holderCount = 0;
            double highestLastBalance = double.MinValue;
            string currentBalanceHolder;
            string highestLastBalanceHolder = "";
            foreach (string entry in peopleAndBalances)
            {
                string[] userHistory = entry.Split(',');

                currentBalanceHolder = userHistory[0];

                double currentBalanceHolderFinalBalance = double.Parse(userHistory[^1]);

                if (highestLastBalance < currentBalanceHolderFinalBalance)
                {
                    highestLastBalanceHolder = currentBalanceHolder;
                    holderCount = 1;
                }

                if (highestLastBalance == currentBalanceHolderFinalBalance &&
                    highestLastBalanceHolder != currentBalanceHolder &&
                    holderCount == 2)
                {
                    highestLastBalanceHolder += ($" and {currentBalanceHolder}");
                }
                if (highestLastBalance == currentBalanceHolderFinalBalance &&
                   highestLastBalanceHolder != currentBalanceHolder &&
                   holderCount == 1)
                {
                    highestLastBalanceHolder += ($", {currentBalanceHolder}");
                    holderCount++;
                }
                highestLastBalance = currentBalanceHolderFinalBalance > highestLastBalance ?
                    currentBalanceHolderFinalBalance : highestLastBalance;
            }
            string stringHighesLasttBalance = highestLastBalance.ToString();

            return holderCount == 1 ? 
                Invariant($"{highestLastBalanceHolder} is the richest person. ¤{stringHighesLasttBalance}.") :
                Invariant($"{highestLastBalanceHolder} are the richest people. ¤{stringHighesLasttBalance}.");
        }

        /// <summary>
        /// Return name and current money of the most poor person.
        /// </summary>
        public static string FindMostPoorPerson(string[] peopleAndBalances)
        {
            {
                if (peopleAndBalances == null || peopleAndBalances.Length == 0)
                {
                    return "N/A.";
                }
                int holderCount = 0;
                double overallLowestLastBalance = double.MaxValue;
                string currentBalanceHolder;
                string overallLowestLastBalanceHolder = "";
                bool isNegativeBalance = false;

                foreach (string entry in peopleAndBalances)
                {
                    string[] userHistory = entry.Split(',');

                    currentBalanceHolder = userHistory[0];

                    double currentBalanceHolderFinalBalance = double.Parse(userHistory[^1]);

                    if (overallLowestLastBalance > currentBalanceHolderFinalBalance)
                    {
                        overallLowestLastBalanceHolder = currentBalanceHolder;
                        holderCount = 1;
                    }

                    if (overallLowestLastBalance == currentBalanceHolderFinalBalance &&
                        overallLowestLastBalanceHolder != currentBalanceHolder &&
                        holderCount == 2)
                    {
                        overallLowestLastBalanceHolder += ($" and {currentBalanceHolder}");
                    }
                    if (overallLowestLastBalance == currentBalanceHolderFinalBalance &&
                        overallLowestLastBalanceHolder != currentBalanceHolder &&
                        holderCount == 1)
                    {
                        overallLowestLastBalanceHolder += ($", {currentBalanceHolder}");
                        holderCount++;
                    }

                    overallLowestLastBalance = overallLowestLastBalance > currentBalanceHolderFinalBalance ? 
                        currentBalanceHolderFinalBalance : overallLowestLastBalance;

                    isNegativeBalance = (overallLowestLastBalance < 0);
                }
                string stringHighesLasttBalance = Math.Abs(overallLowestLastBalance).ToString();
                if (isNegativeBalance)
                {
                    return holderCount == 1 ?
                        Invariant($"{overallLowestLastBalanceHolder} has the least money. -¤{stringHighesLasttBalance}.") :
                        Invariant($"{overallLowestLastBalanceHolder} have the least money. -¤{stringHighesLasttBalance}.");
                }
                return holderCount == 1 ?
                    Invariant($"{overallLowestLastBalanceHolder} has the least money. ¤{stringHighesLasttBalance}.") :
                    Invariant($"{overallLowestLastBalanceHolder} have the least money. ¤{stringHighesLasttBalance}.");
            }
        }
    }
}
