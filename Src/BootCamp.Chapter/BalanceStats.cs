using System.Globalization;
using System.Collections.Generic;

namespace BootCamp.Chapter
{
    public static class BalanceStats
    {
        /// <summary>
        /// Return name and balance(current) of person who had the biggest historic balance.
        /// </summary>
        public static string FindHighestBalanceEver(string[] peopleAndBalances)
        {
            if (peopleAndBalances == null || peopleAndBalances.Length == 0) // ToDo: Implement validation function to make sure it's reusable in other functions as well
            {
                return "N/A.";
            }

            var splitArray = peopleAndBalances[0].Split(','); // We assume that the first array has the highest decimal number in it
            var decimalArray = ConvertStringArrayToDecimalArray(splitArray);
            var largestValueInArrays = FindLargestDecimalInArray(decimalArray);

            var personWithHighestBalance = new[] { splitArray[0] }; // We store the name of the first individual

            for (int i = 1; i < peopleAndBalances.Length; i++)
            {
                var currentSplitArray = peopleAndBalances[i].Split(',');
                var currentDecimalArray = ConvertStringArrayToDecimalArray(currentSplitArray);
                var currentLargestValue = FindLargestDecimalInArray(currentDecimalArray);

                if (currentLargestValue > largestValueInArrays)
                {
                    personWithHighestBalance = new[] { currentSplitArray[0] };
                    largestValueInArrays = currentLargestValue;
                } else if (currentLargestValue == largestValueInArrays)
                {
                    personWithHighestBalance = AppendString(personWithHighestBalance, currentSplitArray[0]);
                }
            }

            return $"{personWithHighestBalance[0]} had the most money ever. ¤{largestValueInArrays}."; ;
        }

        private static decimal[] ConvertStringArrayToDecimalArray(string[] array)
        {
            var decimalArray = new decimal[array.Length];

            for (int i = 0; i < decimalArray.Length; i++)
            {
                decimalArray[i] = decimal.TryParse(array[i], NumberStyles.Any, CultureInfo.InvariantCulture, out decimal parsed) ? parsed : 0.0m;
            }

            return decimalArray;
        }

        private static decimal FindLargestDecimalInArray(decimal[] array)
        {
            var currentHighestDecimal = array[0]; //We assume the first value to be the largest decimal in the array

            for (int i = 1; i < array.Length; i++)
            {
                if (currentHighestDecimal < array[i])
                {
                    currentHighestDecimal = array[i];
                }
            }

            return currentHighestDecimal;
        }

        private static string[] AppendString(string[] array, string stringToAppend)
        {
            var returnArray = new string[array.Length + 1];

            for (int i = 0; i < array.Length; i++)
            {
                returnArray[i] = array[i];
            }
            returnArray[^1] = stringToAppend;
            return returnArray;
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
