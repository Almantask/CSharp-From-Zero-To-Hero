using System.Globalization;
using System.Linq;
using System.Text;
using System;

namespace BootCamp.Chapter
{
    public static class BalanceStats
    {
        public static string FormatString(string strHigh)
        {
            //below block is for formatting the text to be written.
            int index = 0;
            int HoldIndex = 0;
            while (true)
            {
                index = strHigh.IndexOf(",", index);
                if (index > 0)
                {
                    HoldIndex = index;
                    ++index;
                    continue;
                }
                else break;
            }

            //To replace last found ',' with and replace the ',' with ", "
            if (HoldIndex > 0)
            {
                var sb = new StringBuilder(strHigh);
                sb.Remove(HoldIndex, 1);
                sb.Insert(HoldIndex, " and ");
                sb.Replace(",", ", ");
                strHigh = sb.ToString();
            }
            return strHigh;
        }
        /// <summary>
        /// Return name and balance(current) of person who had the biggest historic balance.
        /// </summary>
        public static string FindHighestBalanceEver(string[] peopleAndBalances)
        {

            float LastHighBalance = -99999999.00f;
            string strHigh = "N/A.";

            //If the balances are not having any items or null return N/A.
            if (peopleAndBalances == null || peopleAndBalances.Length == 0)
            {
                return "N/A.";
            }

            foreach (string str in peopleAndBalances)
            {
                //if the strings are empty we shall continue with next iteration
                if (str.Length == 0)
                    continue;

                //strings have balances, so split them with ','.
                string[] PersonDetails = str.Split(",", StringSplitOptions.RemoveEmptyEntries | StringSplitOptions.TrimEntries);

                for (int i = 1; i < PersonDetails.Length; ++i)
                {
                    float balance;
                    bool tryFloat = float.TryParse(PersonDetails[i], NumberStyles.Currency, CultureInfo.CreateSpecificCulture("en-GB"), out balance);
                    if (!tryFloat) continue;
                    //retireve the highest balance.
                    if (LastHighBalance < balance)
                    {
                        LastHighBalance = balance;
                        strHigh = PersonDetails[0];
                    }
                    //People with same high historic balances need to appended.
                    else if (LastHighBalance == balance)
                    {
                        strHigh = string.Concat(strHigh, ",", PersonDetails[0]);
                    }
                }
            }
            //For the array of balances, if there are no balances then return N/A.
            if (strHigh.CompareTo("N/A.") == 0) return strHigh;

            strHigh = FormatString(strHigh);

            return strHigh = string.Concat(strHigh, $" had the most money ever. ¤{LastHighBalance}.");


        }

        /// <summary>
        /// Return name and loss of a person with a biggest loss (balance change negative).
        /// </summary>
        public static string FindPersonWithBiggestLoss(string[] peopleAndBalances)
        {
            float BiggestLoss = 999999999f;
            string strHigh = "N/A.";

            //If the balances are not having any items or null return N/A.
            if (peopleAndBalances == null || peopleAndBalances.Length == 0)
            {
                return "N/A.";
            }

            foreach (string str in peopleAndBalances)
            {
                //if the strings are empty we shall continue with next iteration
                if (str.Length == 0)
                    continue;

                //strings have balances, so split them with ','.
                string[] PersonDetails = str.Split(",", StringSplitOptions.RemoveEmptyEntries | StringSplitOptions.TrimEntries);

                for (int i = 1; i < PersonDetails.Length; ++i)
                {

                    float balance;
                    bool tryFloat = float.TryParse(PersonDetails[i], NumberStyles.Currency, CultureInfo.CreateSpecificCulture("en-GB"), out balance);
                    if (!tryFloat) continue;
                    //retireve the highest balance.
                    if (BiggestLoss > balance)
                    {
                        BiggestLoss = balance;
                        strHigh = PersonDetails[0];
                    }
                    //People with same high historic balances need to appended.
                    else if (BiggestLoss == balance)
                    {
                        strHigh = string.Concat(strHigh, ",", PersonDetails[0]);
                    }
                }
            }

            if (BiggestLoss >= 0) return "N/A.";
            //For the array of balances, if there are no balances then return N/A.
            if (strHigh.CompareTo("N/A.") == 0) return strHigh;

            strHigh = FormatString(strHigh);
            CultureInfo culture = new CultureInfo("de-De");
            return strHigh = string.Concat(strHigh, $" lost the most money. ¤{BiggestLoss}.");
        }

        /// <summary>
        /// Return name and current money of the richest person.
        /// </summary>
        public static string FindRichestPerson(string[] peopleAndBalances)
        {
            float CurrentRichestBal = -99999999.00f;
            string strHigh = "N/A.";
            bool bFlag = false;

            //If the balances are not having any items or null return N/A.
            if (peopleAndBalances == null || peopleAndBalances.Length == 0)
            {
                return "N/A.";
            }

            foreach (string str in peopleAndBalances)
            {
                //if the strings are empty we shall continue with next iteration
                if (str.Length == 0)
                    continue;

                //strings have balances, so split them with ','.
                string[] PersonDetails = str.Split(",", StringSplitOptions.RemoveEmptyEntries | StringSplitOptions.TrimEntries);

                float balance;
                bool tryFloat = float.TryParse(PersonDetails.Last(), NumberStyles.Currency, CultureInfo.CreateSpecificCulture("en-GB"), out balance);
                if (!tryFloat) continue;

                //retireve the highest current balance.
                if (CurrentRichestBal < balance)
                {
                    CurrentRichestBal = balance;
                    strHigh = PersonDetails[0];
                }
                //People with same high historic balances need to appended.
                else if (CurrentRichestBal == balance)
                {
                    bFlag = true;
                    strHigh = string.Concat(strHigh, ",", PersonDetails[0]);
                }
            }
            //For the array of balances, if there are no balances then return N/A.
            if (strHigh.CompareTo("N/A.") == 0) return strHigh;

            strHigh = FormatString(strHigh);
            if (bFlag) return strHigh = string.Concat(strHigh, $" are the richest people. ¤{CurrentRichestBal}.");
            return strHigh = string.Concat(strHigh, $" is the richest person. ¤{CurrentRichestBal}.");
        }

        /// <summary>
        /// Return name and current money of the most poor person.
        /// </summary>
        public static string FindMostPoorPerson(string[] peopleAndBalances)
        {
            float LeastCurrMoney = 99999999.00f;
            string strHigh = "N/A.";
            bool bFlag = false;

            //If the balances are not having any items or null return N/A.
            if (peopleAndBalances == null || peopleAndBalances.Length == 0)
            {
                return "N/A.";
            }

            foreach (string str in peopleAndBalances)
            {
                //if the strings are empty we shall continue with next iteration
                if (str.Length == 0)
                    continue;

                //strings have balances, so split them with ','.
                string[] PersonDetails = str.Split(",", StringSplitOptions.RemoveEmptyEntries | StringSplitOptions.TrimEntries);

                float balance;
                bool tryFloat = float.TryParse(PersonDetails.Last(), NumberStyles.Currency, CultureInfo.CreateSpecificCulture("en-GB"), out balance);
                if (!tryFloat) continue;

                //retireve the highest current balance.
                if (LeastCurrMoney > balance)
                {
                    LeastCurrMoney = balance;
                    strHigh = PersonDetails[0];
                }
                //People with same high historic balances need to appended.
                else if (LeastCurrMoney == balance)
                {
                    bFlag = true;
                    strHigh = string.Concat(strHigh, ",", PersonDetails[0]);
                }
            }
            //For the array of balances, if there are no balances then return N/A.
            if (strHigh.CompareTo("N/A.") == 0) return strHigh;

            strHigh = FormatString(strHigh);
            if (bFlag) return strHigh = string.Concat(strHigh, $" have the least money. ¤{LeastCurrMoney}.");
            return strHigh = string.Concat(strHigh, $" has the least money. ¤{LeastCurrMoney}.");
        }
    }
}
