using System.Globalization;
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
            if (IsStrArrayNullOrEmpty(peopleAndBalances))
            {
                return "N/A.";
            }

            CultureInfo.CurrentCulture = GetCustomInvariantCulture();

            decimal max = decimal.MinValue;
            string maxResult = "";
            string peopleWithSameHighBalance = "";
            bool moreThanOne = false;

            for (int i = 0; i < peopleAndBalances.Length; i++)
            {
                string[] auxBalances = peopleAndBalances[i].Split(',');
                decimal[] balances = GetBalances(auxBalances[1..]);
                decimal currentMax = MaxBalance(balances);
                if (max < currentMax )
                {
                    max = currentMax;
                    peopleWithSameHighBalance = auxBalances[0];
                    moreThanOne = false;
                    maxResult = $" had the most money ever. {max:C0}.";
                }
               else if (max.Equals(currentMax))
                {
                    peopleWithSameHighBalance += $", {auxBalances[0]}";
                    moreThanOne = true;
                }
            }

            if (moreThanOne)
            {
                peopleWithSameHighBalance = ReplaceLastCommaWithAnd(peopleWithSameHighBalance);
            }

            return peopleWithSameHighBalance + maxResult;
        }

        /// <summary>
        /// Return name and loss of a person with a biggest loss (balance change negative).
        /// </summary>
        public static string FindPersonWithBiggestLoss(string[] peopleAndBalances)
        {
            if (IsStrArrayNullOrEmpty(peopleAndBalances))
            {
                return "N/A.";
            }

            CultureInfo.CurrentCulture = GetCustomInvariantCulture();

            decimal min = decimal.MaxValue;
            string minResult = "";
            string peopleWithSameLowBalance = "";
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
                    peopleWithSameLowBalance = auxBalances[0];
                    moreThanOne = false;
                    minResult = $" lost the most money. {min:C0}.";
                }
                else if (min.Equals(currentMin))
                {
                    peopleWithSameLowBalance += $", {auxBalances[0]}";
                    moreThanOne = true;
                }
            }

            if (moreThanOne)
            {
                peopleWithSameLowBalance = ReplaceLastCommaWithAnd(peopleWithSameLowBalance);
            }
            return peopleWithSameLowBalance + minResult;
        }

        /// <summary>
        /// Return name and current money of the richest person.
        /// </summary>
        public static string FindRichestPerson(string[] peopleAndBalances)
        {
            if(IsStrArrayNullOrEmpty(peopleAndBalances))
            {
                return "N/A.";
            }

            CultureInfo.CurrentCulture = GetCustomInvariantCulture();

            decimal max = decimal.MinValue;
            string result = "";
            string richestPeople = "";
            bool moreThanOne = false;

            for (int i = 0; i < peopleAndBalances.Length; i++)
            {
                string[] auxBalances = peopleAndBalances[i].Split(',');

                string value = auxBalances[^1..][0];
                decimal.TryParse(value, out decimal currentBalance);

                if (max < currentBalance)
                {
                    max = currentBalance;
                    richestPeople = auxBalances[0];
                    moreThanOne = false;
                    result = $" is the richest person. {max:C0}.";
                }
                else if(max.Equals(currentBalance))
                {
                    richestPeople += $", {auxBalances[0]}";
                    result = $" are the richest people. {max:C0}.";
                    moreThanOne = true;
                }
            }

            if (moreThanOne)
            {
                richestPeople = ReplaceLastCommaWithAnd(richestPeople);
            }

            return richestPeople + result;
        }

        /// <summary>
        /// Return name and current money of the most poor person.
        /// </summary>
        public static string FindMostPoorPerson(string[] peopleAndBalances)
        {
            if (IsStrArrayNullOrEmpty(peopleAndBalances))
            {
                return "N/A.";
            }

            CultureInfo.CurrentCulture = GetCustomInvariantCulture();

            decimal min = decimal.MaxValue;
            string result = "";
            string poorPeople = "";
            bool moreThanOne = false;

            for (int i = 0; i < peopleAndBalances.Length; i++)
            {
                string[] auxBalances = peopleAndBalances[i].Split(',');
                string value = auxBalances[^1..][0];
                decimal.TryParse(value, out decimal currentBalance);
                if (min > currentBalance)
                {
                    min = currentBalance;
                    poorPeople = auxBalances[0];
                    result = $" has the least money. {min:C0}.";
                    moreThanOne = false;
                }
                else if(min.Equals(currentBalance))
                {
                    poorPeople += $", {auxBalances[0]}";
                    result = $" have the least money. {min:C0}.";
                    moreThanOne = true;
                }
            }

            if (moreThanOne)
            {
                poorPeople = ReplaceLastCommaWithAnd(poorPeople);
            }

            return poorPeople + result;
        }

        private static CultureInfo GetCustomInvariantCulture()
        {
            CultureInfo cult = (CultureInfo)CultureInfo.InvariantCulture.Clone();
            NumberFormatInfo nfi = cult.NumberFormat;
            nfi.CurrencyNegativePattern = 1;
            nfi.CurrencyGroupSeparator = "";

            return cult;
        }

        private static bool IsStrArrayNullOrEmpty(string[] array) 
        {
            if (array == null || array.Length == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private static bool IsDecArrayNullOrEmpty(decimal[] array)
        {
            if (array == null || array.Length == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private static decimal[] GetBalances(string[] balance)
        {
            if (IsStrArrayNullOrEmpty(balance))
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



        private static decimal MaxBalance(decimal[] array)
        {
            if (IsDecArrayNullOrEmpty(array))
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

        private static decimal MinBalance(decimal[] array)
        {
            if (IsDecArrayNullOrEmpty(array))
            {
                return decimal.MinValue;
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


        private static decimal[] GetDiff(decimal[] array)
        {
            if (IsDecArrayNullOrEmpty(array))
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
        /// Replace the last comma with the string " and" in a string with values separated by comma.
        /// </summary>
        /// <param name="value"></param>
        /// <returns>Return a string with the last "," replaced by " and"</returns>
        private static string ReplaceLastCommaWithAnd(string value) 
        {
            int lastComma = value.LastIndexOf(',');
            return value[..lastComma] + " and" + value[(lastComma + 1)..];
        }
    }
}
