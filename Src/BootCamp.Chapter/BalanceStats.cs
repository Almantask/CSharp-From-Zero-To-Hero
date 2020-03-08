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
            if (peopleAndBalances == null) return "";
            
            string[][] workingBalances = ArrayifyBalances(peopleAndBalances);
            int richestPerson = 0;
            string message = $"{workingBalances[richestPerson][0]} : ${workingBalances[richestPerson][^1]}";
            if (workingBalances.Length == 1)
            {
                return message;
            }
            for (int i = 1; i < workingBalances.Length; i++)
            {
                if(float.Parse(workingBalances[i][^1]) > float.Parse(workingBalances[richestPerson][^1]))
                {
                    richestPerson = i;
                }
            }
            return message;
        }

        /// <summary>
        /// Return name and current money of the most poor person.
        /// </summary>
        public static string FindMostPoorPerson(string[] peopleAndBalances)
        {
            if (peopleAndBalances == null) return "";

            string[][] workingBalances = ArrayifyBalances(peopleAndBalances);
            int poorestPerson = 0;
            string message = $"{workingBalances[poorestPerson][0]} : ${workingBalances[poorestPerson][^1]}";
            if (workingBalances.Length == 1)
            {
                return message;
            }
            for (int i = 1; i < workingBalances.Length; i++)
            {
                if (float.Parse(workingBalances[i][^1]) < float.Parse(workingBalances[poorestPerson][^1]))
                {
                    poorestPerson = i;
                }
            }
            return message;
        }

        public static string[][] ArrayifyBalances(string[] peopleAndBalances)
        {
            string[][] parsedBalances = new string[peopleAndBalances.Length][];

            for (int i = 0; i < peopleAndBalances.Length; i++)
            {
                string[] tempArr = PeoplesBalances.Balances[i].Split(',', System.StringSplitOptions.None);
                parsedBalances[i] = tempArr;
            }

            return parsedBalances;
        }
    }
}
