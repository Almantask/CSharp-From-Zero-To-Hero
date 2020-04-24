using System;
using System.Globalization;

namespace BootCamp.Chapter
{
    public static class ArrayOperations
    {
        /// <summary>
        /// Determines whether an array is empty or null and if so, returns true.
        /// </summary>
        /// <param name="array">The array on which the null/length test runs.</param>
        /// <returns></returns>
        public static bool IsArrayNullOrEmpty(string[] array)
        {
            if (array == null || array.Length == 0)
                return true;

            return false;
        }

        /// <summary>
        /// Formats an array of strings to a single string with elements joined together by a comma.
        /// </summary>
        /// <param name="array">The input array whose elements should be formatted as a single string.</param>
        /// <returns></returns>
        public static string FormatArrayToString(string[] array)
        {
            if (array.Length == 1)
            {
                return array[0];
            }

            var formattedString = string.Join(", ", array[..^1]);
            formattedString += $" and {array[^1]}";

            return formattedString;
        }

        /// <summary>
        /// Appends a given string to an array and returns the expanded array as a result.
        /// </summary>
        /// <param name="array">The array to which the string should be added.</param>
        /// <param name="stringToAppend">The string which will be appended to the end of the array.</param>
        /// <returns></returns>
        public static string[] AppendString(string[] array, string stringToAppend)
        {
            var returnArray = new string[array.Length + 1]; // We increase the size of the new array by 1

            for (int i = 0; i < array.Length; i++)
            {
                returnArray[i] = array[i];
            }
            returnArray[^1] = stringToAppend;
            return returnArray;
        }

        /// <summary>
        /// Returns a decimal array based on a given string array. Elements, which cannot be parsed to decimals, are defaulted to 0.0m.
        /// </summary>
        /// <param name="array">The array whose elements will be parsed to decimals and returned as a new array.</param>
        /// <returns></returns>
        public static decimal[] ConvertStringArrayToDecimalArray(string[] array)
        {
            var decimalArray = new decimal[array.Length];

            for (int i = 0; i < decimalArray.Length; i++)
            {
                decimalArray[i] = decimal.TryParse(array[i], NumberStyles.Any, CultureInfo.InvariantCulture, out decimal parsed) ? parsed : 0.0m;
            }

            return decimalArray;
        }

        /// <summary>
        /// Takes a decimal array as input and returns the largest value inside it.
        /// </summary>
        /// <param name="array">The array that will be iterated through and checked for the largest value.</param>
        /// <returns></returns>
        public static decimal FindLargestDecimalInArray(decimal[] array)
        {
            if (array.Length == 0) return 0.0m; // We return 0.0m if there are no values to compare in the passed decimal array

            var currentHighestDecimal = array[0]; // We assume the first value to be the largest decimal in the array

            for (int i = 1; i < array.Length; i++)
            {
                if (currentHighestDecimal < array[i])
                {
                    currentHighestDecimal = array[i];
                }
            }

            return currentHighestDecimal;
        }

        /// <summary>
        /// Takes a decimal array as input and returns the smallest value inside it.
        /// </summary>
        /// <param name="array">The array that will be iterated through and checked for the smallest value.</param>
        /// <returns></returns>
        public static decimal FindSmallestDecimalInArray(decimal[] array)
        {
            if (array.Length == 0) return 0.0m; // We return 0.0m if there are no values to compare in the passed decimal array

            var currentSmallestDecimal = array[0]; // We assume the first value to be the smallest decimal in the array

            for (int i = 1; i < array.Length; i++)
            {
                if (currentSmallestDecimal > array[i])
                {
                    currentSmallestDecimal = array[i];
                }
            }

            return currentSmallestDecimal;
        }
    }

    public enum OperationType
    {
        FindLargestValue,
        FindSmallestValue,
        FindBiggestDiscrepancy,
        FindLastValue
    }
}