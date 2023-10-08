using System;
using System.Text;
using System.Globalization;
using System.Runtime.Intrinsics.Arm;
using System.Reflection;
using System.Linq;

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
                    //retireve the highest balance.
                    if (LastHighBalance < float.Parse(PersonDetails[i]))
                    {
                        LastHighBalance = float.Parse(PersonDetails[i]);
                        strHigh = PersonDetails[0];
                    }
                    //People with same high historic balances need to appended.
                    else if (LastHighBalance == float.Parse(PersonDetails[i]))
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
                    //retireve the highest balance.
                    if (BiggestLoss > float.Parse(PersonDetails[i]))
                    {
                        BiggestLoss = float.Parse(PersonDetails[i]);
                        strHigh = PersonDetails[0];
                    }
                    //People with same high historic balances need to appended.
                    else if (BiggestLoss == float.Parse(PersonDetails[i]))
                    {
                        strHigh = string.Concat(strHigh, ",", PersonDetails[0]);
                    }
                }
            }

            if (BiggestLoss >= 0) return "N/A.";
            //For the array of balances, if there are no balances then return N/A.
            if (strHigh.CompareTo("N/A.") == 0 ) return strHigh;

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

                    //retireve the highest current balance.
                    if (CurrentRichestBal < float.Parse(PersonDetails.Last()))
                    {
                        CurrentRichestBal = float.Parse(PersonDetails.Last());
                        strHigh = PersonDetails[0];
                    }
                    //People with same high historic balances need to appended.
                    else if (CurrentRichestBal == float.Parse(PersonDetails.Last()))
                    {
                    bFlag = true;
                    strHigh = string.Concat(strHigh, ",", PersonDetails[0]);
                    }
            }
            //For the array of balances, if there are no balances then return N/A.
            if (strHigh.CompareTo("N/A.") == 0) return strHigh;

            strHigh = FormatString(strHigh);
            if(bFlag) return strHigh = string.Concat(strHigh, $" are the richest people. ¤{CurrentRichestBal}.");
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

                //retireve the highest current balance.
                if (LeastCurrMoney > float.Parse(PersonDetails.Last()))
                {
                    LeastCurrMoney = float.Parse(PersonDetails.Last());
                    strHigh = PersonDetails[0];
                }
                //People with same high historic balances need to appended.
                else if (LeastCurrMoney == float.Parse(PersonDetails.Last()))
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
