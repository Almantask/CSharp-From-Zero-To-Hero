using System;

namespace BootCamp.Chapter
{
    public static class ArrayOps
    {
        public static bool CheckValidity(string[] peopleAndBalance)
        {
            foreach (string field in peopleAndBalance)
            {
                string[] account = ConvertToAccountArray(field);
                if (!Test.IsName(account[0]) || !Test.IsBalance(account[1..]))
                {
                    return false;
                }
            }
            return true;
        }

        public static string[] ConvertToAccountArray(string personAndBalance)
        {
            string[] newArray;
            try
            {
                newArray = personAndBalance.Split(Settings.stringSplitDivider);
            }
            catch (Exception)
            {
                throw new InvalidBalancesException();
            }
            return newArray;
        }

        public static decimal FindMax(decimal[] inputArray)
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

        public static decimal FindMin(decimal[] inputArray)
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

        public static bool CheckEquality(decimal[] array1, decimal[] array2)
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