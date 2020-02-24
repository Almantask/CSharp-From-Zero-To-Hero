using System;

namespace BootCamp.Chapter
{
    public static class ArrayOps
    {
        public static bool IsArrayValid(string[] inputArray)
        {
            return inputArray != null && inputArray.Length != 0;
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

        public static string[] ConvertToAccountArray(string personAndBalance, char delimiter)
        {
            string[] newArray;
            try
            {
                newArray = personAndBalance.Split(delimiter);
            }
            catch (Exception)
            {
                throw new InvalidBalancesException();
            }
            return newArray;
        }
    }
}