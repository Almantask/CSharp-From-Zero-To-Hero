﻿using System;

namespace BootCamp.Chapter
{
    public static class ArrayOps
    {
        public static bool IsArrayValid(string[] inputArray)
        {
            return inputArray != null && inputArray.Length != 0;
        }

        public static string GetNameForPerson(string personAndBalance)
        {
            var balanceList = personAndBalance.Split(',');

            if (Test.IsStringValid(balanceList[0]))
            {
                return balanceList[0];
            }

            return StringOps.InvalidMessage;
        }

        public static decimal[] GetBalanceForPerson(string personAndBalance)
        {
            if (!Test.IsStringValid(personAndBalance))
            {
                return default;
            }

            var array = personAndBalance.Split(',');
            var newArray = new decimal[array.Length - 1];
            for (int i = 1; i < array.Length; i++)
            {
                newArray[i - 1] = Test.ConvertToDecimal(array[i]);
            }

            return newArray;
        }

        public static decimal FindArrayMax(decimal[] inputArray)
        {
            decimal max = inputArray[0];
            for (int i = 1; i < inputArray.Length; i++)
            {
                if (inputArray[i] > max)
                {
                    max = inputArray[i];
                }
            }
            return max;
        }

        public static decimal FindArrayMin(decimal[] inputArray)
        {
            var min = inputArray[0];
            for (int i = 0; i < inputArray.Length; i++)
            {
                if (inputArray[i] < min)
                {
                    min = inputArray[i];
                }
            }
            return min;
        }

        public static bool AreArraysEqual(decimal[] array1, decimal[] array2)
        {
            for (int i = 0; i < array1.Length; i++)
            {
                if (array1[i] != array2[i])
                {
                    return false;
                }
            }
            return true;
        }
    }
}