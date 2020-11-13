using System;
using System.Collections.Immutable;

namespace BootCamp.Chapter1
{
    public static class ArrayOperations
    {
        /// <summary>
        /// Sort the array in ascending order.
        /// If array empty or null- don't do anything.
        /// </summary>
        /// <param name="array">Input array in a random order.</param>
        ///
        public static void Sort(int[] array)
        {
            if (!IsArrayNullOrEmpty(array))
            {
                for (int i = 0; i < array.Length - 1; i++)
                {
                    SortUpToIndex(array, i);
                }
            }
        }

        /// <summary>
        /// Reverse the array elements, first being last and so on.
        /// If array empty or null- don't do anything.
        /// </summary>
        /// <param name="array">Input array in a random order.</param>
        public static void Reverse(int[] array)
        {
            if (!IsArrayNullOrEmpty(array))
            {
                for (int i = 0; i < array.Length / 2; i++)
                {
                    int stashedValue = array[i];
                    int indexToCompare = array.Length - i - 1;
                    array[i] = array[indexToCompare];
                    array[indexToCompare] = stashedValue;
                }

            }
        }

        /// <summary>
        /// Remove last element in array.
        /// </summary>
        /// <param name="array">Input array.</param>
        /// <returns>A new array with the last element removed. If an array is empty or null, returns input array.</returns>
        public static int[] RemoveLast(int[] array)
        {
            int index = IsArrayNullOrEmpty(array) ? 0 : array.Length - 1;
            return RemoveAt(array, index);
        }

        /// <summary>
        /// Remove first element in array.
        /// </summary>
        /// <returns>A new array with the first element removed. If an array is empty or null, returns input array.</returns>
        public static int[] RemoveFirst(int[] array)
        {
            return RemoveAt(array, 0);
        }

        /// <summary>
        /// Removes array element at given index.
        /// </summary>
        /// <param name="array">Input array.</param>
        /// <param name="index">Index at which array element should be removed.</param>
        /// <returns>A new array with element removed at a given index. If an array is empty or null, returns input array.</returns>
        public static int[] RemoveAt(int[] array, int index)
        {
            if (IsArrayNullOrEmpty(array)) return array;
            if (!IsValidIndex(array, index)) return array;
            
            int[] results = new int[array.Length - 1];
            for (int i = 0; i < results.Length; i++)
            {
                if (i < index) results[i] = array[i];
                else if (i >= index) results[i] = array[i + 1];
            }
            return results;
        }

        /// <summary>
        /// Inserts a new array element at the start.
        /// </summary>
        /// <param name="array">Input array.</param>
        /// <param name="number">Number to be added.</param>
        /// <returns>A new array with element added at a given index. If an array is empty or null, returns new array with number in it.</returns>
        public static int[] InsertFirst(int[] array, int number)
        {
            
            return InsertAt(array, number, 0);
        }

        /// <summary>
        /// Inserts a new array element at the end.
        /// </summary>
        /// <param name="array">Input array.</param>
        /// <param name="number">Number to be added.</param>
        /// <returns>A new array with element added in the end of array. If an array is empty or null, returns new array with number in it.</returns>
        public static int[] InsertLast(int[] array, int number)
        {
            int index = IsArrayNullOrEmpty(array) ? 0 : array.Length;
            return InsertAt(array, number, index);
        }

        /// <summary>
        /// Inserts a new array element at the specified index.
        /// </summary>
        /// <param name="array">Input array.</param>
        /// <param name="number">Number to be added.</param>
        /// <param name="index">Index at which array element should be added.</param>
        /// <returns>A new array with element inserted at a given index. If an array is empty or null, returns new array with number in it.</returns>
        public static int[] InsertAt(int[] array, int number, int index)
        {
            if (IsArrayNullOrEmpty(array) && index == 0)
            {
                return new int[] { number };
            }
            else if (IsArrayNullOrEmpty(array) && index != 0)
            {
                return new int[0];
            }

            int[] results = new int[array.Length + 1];
            for (int i = 0; i < array.Length; i++)
            {
                if (i < index) results[i] = array[i];
                else if (i > index) results[i] = array[i + 1];
                results[index] = number;
            }
            return results;
        }

        /// <summary>
        /// Checks whether an array of ints is null or empty.
        /// </summary>
        /// <param name="array">Input array.</param>
        /// <returns>True if  an array is null or has a length of zero.</returns>
        private static bool IsArrayNullOrEmpty(int[] array)
        {
            return (array == null || array.Length == 0);
        }

        /// <summary>
        /// Checks whether an index is valid for the passed array of ints.
        /// </summary>
        /// <param name="array">Input array.</param>
        /// <param name="index">Input index.</param>
        /// <returns>True if the index is equal to zero and less than the array length.</returns>
        private static bool IsValidIndex(int[] array, int index)
        {
            return (index >= 0 && index < array.Length);
        }

        /// <summary>
        /// Sorts an array up to the selected index.
        /// </summary>
        /// <param name="array">Input array.</param>
        /// <param name="stopIndex">Index to stop the sort at.</param>
        private static void SortUpToIndex(int[] array, int stopIndex)
        {
            for (int indexToCheck = 0; indexToCheck < array.Length - stopIndex - 1; indexToCheck++)
            {
                int nextIndex = indexToCheck + 1;
                if (array[indexToCheck] <= array[nextIndex]) continue;
                else
                {
                    int stashedValue = array[indexToCheck];
                    array[indexToCheck] = array[nextIndex];
                    array[nextIndex] = stashedValue;
                }
            }
        }
    }
}
