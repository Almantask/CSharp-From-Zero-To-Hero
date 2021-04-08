using System.Collections.Generic;
using System.IO;

namespace BootCamp.Chapter
{
    public static class BalanceStats
    {
        /// <summary>
        /// Return name and balance(current) of person who had the biggest historic balance.
        /// </summary>
        public static string FindHighestBalanceEver(string[] peopleAndBalances)
        {
            return "";
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
            string solutionStr = "";
            int currentMoneyRichest = 0;
            if(peopleAndBalances == null) return "N/A.";
            if (peopleAndBalances.Length == 0) return "N/A.";
            for(int i = 0; i < peopleAndBalances.Length; i++)
            {
                string[] words = peopleAndBalances[i].Split(",");
                if(int.Parse(words[words.Length - 1]) > currentMoneyRichest){
                    currentMoneyRichest = int.Parse(words[words.Length - 1]);
                }
            }
            for(int j = 0; j < peopleAndBalances.Length; j++)
            {
                string[] words = peopleAndBalances[j].Split(",");
                if(int.Parse(words[words.Length - 1]) == currentMoneyRichest)
                {
                    solutionStr += " " + words[0];
                }
            }
            solutionStr += " " +currentMoneyRichest;
            return solutionStr;
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
