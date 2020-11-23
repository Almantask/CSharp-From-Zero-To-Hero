using System;
using System.Globalization;

namespace BootCamp.Chapter
{
    public static class ArrayOperations
    {
        private static decimal DecimalErrorCode = -1M;
        
        public static decimal[] ConvertStrArrayToDecimalArray(string[] arr)
        {
            if (IsArrayNullOrEmpty(arr)) return new decimal[]{DecimalErrorCode};
            var results = new decimal[arr.Length];
            for (var i = 0; i < arr.Length; i++)
            {
                decimal number;
                if (decimal.TryParse(arr[i], NumberStyles.Currency, CultureInfo.InvariantCulture, out number))
                    results[i] = number;
            }
            return results;
        }
        public static string[] InsertAt(string[] arr, string content, int index)
        {
            if (IsArrayNullOrEmpty(arr) && index == 0) return new string[] { content };
            if (IsArrayNullOrEmpty(arr) && index != 0) return new string[] {string.Empty};

            var indexInsideArray = 0;
            var results = new string[arr.Length + 1];
            for (int indexInsideResults = 0; indexInsideResults < results.Length; indexInsideResults++)
            {
                if (indexInsideResults == index)
                {
                    results[indexInsideResults] = content;
                    indexInsideArray--;
                }
                else results[indexInsideResults] = arr[indexInsideArray];
                indexInsideArray++;
            }
            return results;
        }
        
        public static string FormatToString(string[] arr)
        {
            if (IsArrayNullOrEmpty(arr)) return string.Empty;
            if (arr.Length <= 2) return string.Join(" and ", arr);
            var namesWithComma = string.Join(", ", arr[..^1]);
            return $@"{namesWithComma} and {arr[^1]}";
        }

        public static decimal FindHighestBalanceIn(decimal[] arr)
        {
            var highestBalance = decimal.MinValue;
            foreach (var balance in arr)
            {
                if (balance > highestBalance) highestBalance = balance;
            }

            return highestBalance;
        }
        
        public static decimal FindLowestBalanceIn(decimal[] arr)
        {
            var lowestBalance = decimal.MaxValue;
            foreach (var balance in arr)
            {
                if (balance < lowestBalance) lowestBalance = balance;
            }

            return lowestBalance;
        }
        
        public static int ReturnLongestStringLengthInArray(string[] arr)
        {
            var maxLength = int.MinValue;
            foreach (var item in arr)
            {
                if (item.Length > maxLength) maxLength = item.Length;
            }

            return maxLength;
        }
        public static bool IsArrayNullOrEmpty(string[] arr)
        {
            return (arr == null || arr.Length == 0);
        }
    }
}