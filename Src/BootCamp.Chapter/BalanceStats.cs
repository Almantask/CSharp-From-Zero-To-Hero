using System;

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
            return "";
        }

        /// <summary>
        /// Return name and current money of the richest person.
        /// </summary>
        public static string FindRichestPerson(string[] peopleAndBalances)
        {
            return "";
        }

        /// <summary>
        /// Return name and current money of the most poor person.
        /// </summary>
        public static string FindMostPoorPerson(string[] peopleAndBalances)
        {
            return "";
        }
        
    }
}
