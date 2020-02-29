using System.Globalization;
using System;
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
            if (IsNullOrEmpty(peopleAndBalances))
            {
                return "N/A.";
            }

            CultureInfo.CurrentCulture = GetCustomInvariantCulture();

            decimal max = decimal.MinValue;
            string maxResult = "";
            StringBuilder peopleWithSameHighBalance = new StringBuilder();
            bool moreThanOne = false;

            for (int i = 0; i < peopleAndBalances.Length; i++)
            {
                string[] auxBalances = peopleAndBalances[i].Split(',');
                decimal[] balances = GetBalances(auxBalances[1..]);
                decimal currentMax = MaxBalance(balances);
                if (max < currentMax )
                {
                    max = currentMax;
                    peopleWithSameHighBalance.Clear();
                    peopleWithSameHighBalance.Append(auxBalances[0]);
                    moreThanOne = false;
                    maxResult = $" had the most money ever. {max:C0}.";
                }
               else if (max.Equals(currentMax))
                {
                    peopleWithSameHighBalance.Append($", {auxBalances[0]}");
                    moreThanOne = true;
                }
            }

            if (moreThanOne)
            {
                ReplaceLastCommaWithAnd(peopleWithSameHighBalance);
            }
            peopleWithSameHighBalance.Append(maxResult);
            return peopleWithSameHighBalance.ToString();
        }

        /// <summary>
        /// Return name and loss of a person with a biggest loss (balance change negative).
        /// </summary>
        public static string FindPersonWithBiggestLoss(string[] peopleAndBalances)
        {
            if (IsNullOrEmpty(peopleAndBalances))
            {
                return "N/A.";
            }

            CultureInfo.CurrentCulture = GetCustomInvariantCulture();

            decimal min = decimal.MaxValue;
            string minResult = "";
            StringBuilder peopleWithSameLowBalance = new StringBuilder();
            bool moreThanOne = false;

            for (int i = 0; i < peopleAndBalances.Length; i++)
            {
                string[] auxBalances = peopleAndBalances[i].Split(',');
                decimal[] balances = GetBalances(auxBalances[1..]);

                if (balances.Length <= 1)
                {
                    return "N/A.";
                }
         
                decimal currentMin = MinBalance(GetDiff(balances));
                if (min > currentMin)
                {
                    min = currentMin;
                    peopleWithSameLowBalance.Clear();
                    peopleWithSameLowBalance.Append(auxBalances[0]);
                    moreThanOne = false;
                    minResult = $" lost the most money. {min:C0}.";
                }
                else if (min.Equals(currentMin))
                {
                    peopleWithSameLowBalance.Append($", {auxBalances[0]}");
                    moreThanOne = true;
                }
            }

            if (moreThanOne)
            {
                ReplaceLastCommaWithAnd(peopleWithSameLowBalance);
            }
            peopleWithSameLowBalance.Append(minResult);
            return peopleWithSameLowBalance.ToString();
        }

        /// <summary>
        /// Return name and current money of the richest person.
        /// </summary>
        public static string FindRichestPerson(string[] peopleAndBalances)
        {
            if(IsNullOrEmpty(peopleAndBalances))
            {
                return "N/A.";
            }

            CultureInfo.CurrentCulture = GetCustomInvariantCulture();

            decimal max = decimal.MinValue;
            string result = "";
            StringBuilder richestPeople = new StringBuilder();
            bool moreThanOne = false;

            for (int i = 0; i < peopleAndBalances.Length; i++)
            {
                string[] auxBalances = peopleAndBalances[i].Split(',');

                string value = auxBalances[^1..][0];
                decimal.TryParse(value, out decimal currentBalance);

                if (max < currentBalance)
                {
                    max = currentBalance;
                    richestPeople.Clear();
                    richestPeople.Append(auxBalances[0]);
                    moreThanOne = false;
                    result = $" is the richest person. {max:C0}.";
                }
                else if(max.Equals(currentBalance))
                {
                    richestPeople.Append($", {auxBalances[0]}");
                    result = $" are the richest people. {max:C0}.";
                    moreThanOne = true;
                }
            }

            if (moreThanOne)
            {
                ReplaceLastCommaWithAnd(richestPeople);
            }
            richestPeople.Append(result);
            return richestPeople.ToString();
        }

        /// <summary>
        /// Return name and current money of the most poor person.
        /// </summary>
        public static string FindMostPoorPerson(string[] peopleAndBalances)
        {
            if (IsNullOrEmpty(peopleAndBalances))
            {
                return "N/A.";
            }

            CultureInfo.CurrentCulture = GetCustomInvariantCulture();

            decimal min = decimal.MaxValue;
            string result = "";
            StringBuilder poorPeople = new StringBuilder();
            bool moreThanOne = false;

            for (int i = 0; i < peopleAndBalances.Length; i++)
            {
                string[] auxBalances = peopleAndBalances[i].Split(',');
                string value = auxBalances[^1..][0];
                decimal.TryParse(value, out decimal currentBalance);
                if (min > currentBalance)
                {
                    min = currentBalance;
                    poorPeople.Clear();
                    poorPeople.Append(auxBalances[0]);
                    result = $" has the least money. {min:C0}.";
                    moreThanOne = false;
                }
                else if(min.Equals(currentBalance))
                {
                    poorPeople.Append($", {auxBalances[0]}");
                    result = $" have the least money. {min:C0}.";
                    moreThanOne = true;
                }
            }

            if (moreThanOne)
            {
                ReplaceLastCommaWithAnd(poorPeople);
            }
            poorPeople.Append(result);
            return poorPeople.ToString();
        }

        /// <summary>
        /// Makes a customizable invariant culture without currencygroupseparator and currencynegativepattern = 1
        /// </summary>
        /// <returns>an Invariant Culture CultureInfo</returns>
        private static CultureInfo GetCustomInvariantCulture()
        {
            CultureInfo culture = (CultureInfo)CultureInfo.InvariantCulture.Clone();
            NumberFormatInfo nfi = culture.NumberFormat;
            nfi.CurrencyNegativePattern = 1;
            nfi.CurrencyGroupSeparator = "";

            return culture;
        }

        /// <summary>
        /// verify if string array is null or empty
        /// </summary>
        /// <param name="array"></param>
        /// <returns></returns>
        private static bool IsNullOrEmpty(string[] array) 
        {
            return (array == null || array.Length == 0);
        }

        /// <summary>
        /// verify if decimal array is null or empty
        /// </summary>
        /// <param name="array"></param>
        /// <returns></returns>
        private static bool IsNullOrEmpty(decimal[] array)
        {
            return (array == null || array.Length == 0);
        }

        /// <summary>
        /// convert the string values in the balance array to decimal.
        /// Note: it will skip null or empty strings,  return array.Length <= balance.Length
        /// </summary>
        /// <param name="balance"></param>
        /// <returns></returns>
        private static decimal[] GetBalances(string[] balance)
        {
            if (IsNullOrEmpty(balance))
            {
                return null;
            }
            decimal[] auxArray = new decimal[balance.Length];

            int j = 0;
            
            for (int i = 0; i < balance.Length; i++)
            {
                if (!string.IsNullOrWhiteSpace(balance[i]))
                {
                    decimal.TryParse(balance[i], out auxArray[j]);
                    j++;
                }
                
            }

            return auxArray[..j];
        }


        /// <summary>
        /// Calculte the max balance
        /// </summary>
        /// <param name="array"></param>
        /// <returns></returns>
        private static decimal MaxBalance(decimal[] array)
        {
            if (IsNullOrEmpty(array))
            {
                return decimal.MinValue;
            }

            decimal max = decimal.MinValue;

            for (int i = 0; i < array.Length; i++)
            {
                if (max < array[i])
                {
                    max = array[i];
                }
            }
            return max;
        }
        /// <summary>
        /// Calculate min balance
        /// </summary>
        /// <param name="array"></param>
        /// <returns></returns>
        private static decimal MinBalance(decimal[] array)
        {
            if (IsNullOrEmpty(array))
            {
                return decimal.MaxValue;
            }

            decimal min = decimal.MaxValue;

            for (int i = 0; i < array.Length; i++)
            {
                if (min > array[i])
                {
                    min = array[i];
                }
            }
            return min;
        }

        /// <summary>
        /// calculate the balance difference array: Balance[i+1] - Balance[i] with i < Balance.Legth - 1
        /// </summary>
        /// <param name="array"></param>
        /// <returns>an array with the differences</returns>
        private static decimal[] GetDiff(decimal[] array)
        {
            if (IsNullOrEmpty(array))
            {
                return array;
            }

            if (array.Length == 1)
            {
                return new decimal[] { 0 };
            }

            decimal[] auxArray = new decimal[array.Length - 1];

            for (int i = 0; i < array.Length - 1; i++)
            {
                auxArray[i] = array[i+1] - array[i];
            }

            return auxArray;
        }

        /// <summary>
        /// Changes the Strinbuilder instance by Replacing the last comma with the string " and" in a string with values separated by comma.
        /// </summary>
        /// <param name="sb"></param>
        private static void ReplaceLastCommaWithAnd(StringBuilder sb) 
        {
            int lastComma = sb.ToString().LastIndexOf(",", StringComparison.InvariantCulture);
            sb.Replace(",", " and", lastComma, 1);
        }
    }
}
