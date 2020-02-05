﻿using System;
using System.Globalization;
using System.Threading;


namespace BootCamp.Chapter
{
    public static class BalanceStats
    {

        /// <summary>
        /// Return name and balance(current) of person who had the biggest historic balance.
        /// </summary>
        public static string FindHighestBalanceEver(string[] peopleAndBalances)
        {
            if (peopleAndBalances==null || peopleAndBalances.Length == 0)
            {
                return "N/A.";
            }
            float highestBalance = float.MinValue;
            string currentBalanceHolder = "";
            string highestBalanceHolder = "";
            int holderCount = 0;
            foreach (string entry in peopleAndBalances)
            {
                string[] userHistory = entry.Split(',');

                foreach (string userEntry in userHistory)
                {
                    bool isFloat = float.TryParse(userEntry, out float result);
                    if (!isFloat)
                    {
                        currentBalanceHolder = userEntry;
                    }

                    else
                    {
                        float balance = float.Parse(userEntry);
                        if (balance > highestBalance)
                        {
                            highestBalance = balance;
                            highestBalanceHolder = currentBalanceHolder;
                        }
                        if (balance == highestBalance && highestBalanceHolder != currentBalanceHolder)
                        {
                            if (holderCount == 1)
                            {

                                highestBalanceHolder += ($" and {currentBalanceHolder}");

                            }
                            else
                            {
                                highestBalanceHolder += ($", {currentBalanceHolder}");
                                holderCount++;
                            }
                        }
                    }
                }
            }
            string stringHighestBalance = highestBalance.ToString();
            return ($"{highestBalanceHolder} had the most money ever. ¤{stringHighestBalance}.");
        }

        /// <summary>
        /// Return name and loss of a person with a biggest loss (balance change negative).
        /// </summary>
        public static string FindPersonWithBiggestLoss(string[] peopleAndBalances)
        {
            float biggestLoss = 0f;
            float balance;
            float nextBalance;
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
                  
                    balance = float.TryParse(userHistory[i], out float result) ? float.Parse(userHistory[i]) : float.NaN;

                    nextBalance = float.TryParse(userHistory[i + 1], out float nextResult) ? float.Parse(userHistory[i + 1]) : float.NaN;

                    biggestLoss = ((nextBalance - balance) < biggestLoss) ? (nextBalance - balance) : biggestLoss;



                    if (biggestLoss == nextBalance - balance && biggestLoser != currentBalanceHolder)
                    {
                        switch (holderCount)
                        {
                            case 0:
                                {
                                    biggestLoser = currentBalanceHolder;
                                    holderCount++;
                                    break;
                                }

                            case 1:
                                {
                                    biggestLoser += ($", {currentBalanceHolder}");
                                    holderCount++;
                                    break;
                                }
                            case 3:
                                {
                                    biggestLoser += ($" and {currentBalanceHolder}");
                                    break;
                                }
                        }
                    }
                }
            }
            string stringBiggestLoss = Math.Abs(biggestLoss).ToString();
            return ($"{biggestLoser} lost the most money. -¤{stringBiggestLoss}.");
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
            float highestLastBalance = float.MinValue;
            string currentBalanceHolder;
            string highestLastBalanceHolder = "";
            foreach (string entry in peopleAndBalances)
            {
                string[] userHistory = entry.Split(',');

                currentBalanceHolder = userHistory[0];
                    
                float finalBalance = float.Parse(userHistory[^1]);

                

                if (highestLastBalance < finalBalance)
                {
                    highestLastBalanceHolder = currentBalanceHolder;
                    holderCount = 1;
                }

                if (highestLastBalance == finalBalance && highestLastBalanceHolder != currentBalanceHolder)
                {                   
                        switch (holderCount)
                        {
                            case 1:
                                {
                                    highestLastBalanceHolder += ($", {currentBalanceHolder}");
                                    holderCount++;
                                    break;
                                }
                            case 2:
                                {
                                    highestLastBalanceHolder += ($" and {currentBalanceHolder}");
                                    break;
                                }
                        }
                    }
                highestLastBalance = highestLastBalance < finalBalance ? finalBalance : highestLastBalance;
            }
            string stringHighesLasttBalance = highestLastBalance.ToString();
            return holderCount == 1 ? ($"{highestLastBalanceHolder} is the richest person. ¤{stringHighesLasttBalance}.") : ($"{highestLastBalanceHolder} are the richest people. ¤{stringHighesLasttBalance}.");
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
                float lowestLastBalance = float.MaxValue;
                string currentBalanceHolder;
                string lowestLastBalanceHolder = "";
                bool isNegativeBalance = false;

                foreach (string entry in peopleAndBalances)
                {
                    string[] userHistory = entry.Split(',');

                    currentBalanceHolder = userHistory[0];

                    float finalBalance = float.Parse(userHistory[^1]);

                    if (lowestLastBalance > finalBalance)
                    {
                        lowestLastBalanceHolder = currentBalanceHolder;
                        holderCount = 1;
                    }

                    if (lowestLastBalance == finalBalance && lowestLastBalanceHolder != currentBalanceHolder)
                    {
                        switch (holderCount)
                        {
                            case 1:
                                {
                                    lowestLastBalanceHolder += ($", {currentBalanceHolder}");
                                    holderCount++;
                                    break;
                                }
                            case 2:
                                {
                                    lowestLastBalanceHolder += ($" and {currentBalanceHolder}");
                                    break;
                                }
                        }
                    }
                    lowestLastBalance = lowestLastBalance > finalBalance ? finalBalance : lowestLastBalance;

                    isNegativeBalance = (lowestLastBalance < 0);
                    
                }
                string stringHighesLasttBalance = Math.Abs(lowestLastBalance).ToString();
                if (isNegativeBalance)
                {
                    return holderCount == 1 ? ($"{lowestLastBalanceHolder} has the least money. -¤{stringHighesLasttBalance}.") : ($"{lowestLastBalanceHolder} have the least money. -¤{stringHighesLasttBalance}.");
                }
                return holderCount == 1 ? ($"{lowestLastBalanceHolder} has the least money. ¤{stringHighesLasttBalance}.") : ($"{lowestLastBalanceHolder} have the least money. ¤{stringHighesLasttBalance}.");
            }
        }
        
    }
}
