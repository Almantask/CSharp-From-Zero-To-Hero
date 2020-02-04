using System;
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
            float highestBalance = 0f;
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
            string currentBalanceHolder = "";
            float balance = 0f;
            float nextBalance = 0f;
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
                    return "N/A.";


                for (int i = 0; i < userHistory.Length - 1; i++)
                {
                    bool isFloat = float.TryParse(userHistory[i], out float result);
                    if (!isFloat)
                    {
                        currentBalanceHolder = userHistory[i];
                    }

                    else
                    {
                        balance = float.Parse(userHistory[i]);
                        nextBalance = float.Parse(userHistory[i + 1]);

                        biggestLoss = ((nextBalance - balance) < biggestLoss) ? (nextBalance - balance) : biggestLoss;

                        //biggestLoser = biggestLoss == nextBalance - balance ? currentBalanceHolder : biggestLoser;


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
            float highestLastBalance = 0f;
            string currentBalanceHolder = "";
            string highestLastBalanceHolder = "";
            foreach (string entry in peopleAndBalances)
            {
                string[] userHistory = entry.Split(',');

                currentBalanceHolder = userHistory[0];
                    
                float finalBalance = float.Parse(userHistory[^1]);

                highestLastBalance = highestLastBalance < finalBalance ? finalBalance : highestLastBalance;

                if (highestLastBalance == finalBalance && highestLastBalanceHolder != currentBalanceHolder)
                {                   
                        switch (holderCount)
                        {
                            case 0:
                                {
                                    highestLastBalanceHolder = currentBalanceHolder;
                                    holderCount++;
                                    break;
                                }

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
                }
            string stringHighesLasttBalance = highestLastBalance.ToString();
            return holderCount == 0 ? ($"{highestLastBalanceHolder} is the richest person. ¤{stringHighesLasttBalance}.") : ($"{highestLastBalanceHolder} are the richest people. ¤{stringHighesLasttBalance}.");
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
                float lowestLastBalance = 0f;
                string currentBalanceHolder = "";
                string lowestLastBalanceHolder = "";
                bool isNegativeBalance = false;

                foreach (string entry in peopleAndBalances)
                {
                    string[] userHistory = entry.Split(',');

                    currentBalanceHolder = userHistory[0];

                    float finalBalance = float.Parse(userHistory[^1]);

                    lowestLastBalance = lowestLastBalance > finalBalance ? finalBalance : lowestLastBalance;

                    if (lowestLastBalance == finalBalance && lowestLastBalanceHolder != currentBalanceHolder)
                    {
                        switch (holderCount)
                        {
                            case 0:
                                {
                                    lowestLastBalanceHolder = currentBalanceHolder;
                                    holderCount++;
                                    break;
                                }

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
                        isNegativeBalance = (lowestLastBalance < 0);
                    }
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
