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
        private static bool IsArrayTruthy(int[] array)
        {
            return !(array == null || array.Length == 0);
        }

        public static void Sort(int[] array)
        {
            if (IsArrayTruthy(array)) Array.Sort(array);
        }

        /// <summary>
        /// Reverse the array elements, first being last and so on.
        /// If array empty or null- don't do anything.
        /// </summary>
        /// <param name="array">Input array in a random order.</param>
        public static void Reverse(int[] array)
        {
            if (IsArrayTruthy(array)) Array.Reverse(array);
        }

        /// <summary>
        /// Remove last element in array.
        /// </summary>
        /// <param name="array">Input array.</param>
        /// <returns>A new array with the last element removed. If an array is empty or null, returns input array.</returns>
        public static int[] RemoveLast(int[] array)
        {
            if (!IsArrayTruthy(array)) return array;

            int[] results = new int[array.Length - 1];
            Array.Copy(array, results, array.Length - 1);
            return results;
        }

        /// <summary>
        /// Remove first element in array.
        /// </summary>
        /// <returns>A new array with the first element removed. If an array is empty or null, returns input array.</returns>
        public static int[] RemoveFirst(int[] array)
        {
            if (!IsArrayTruthy(array)) return array;

            int[] results = new int[array.Length - 1];
            for (int i = 0; i < results.Length; i++)
            {
                results[i] = array[i + 1];
            }
            return results;

        }

        /// <summary>
        /// Removes array element at given index.
        /// </summary>
        /// <param name="array">Input array.</param>
        /// <param name="index">Index at which array element should be removed.</param>
        /// <returns>A new array with element removed at a given index. If an array is empty or null, returns input array.</returns>
        public static int[] RemoveAt(int[] array, int index)
        {
            // ToDo: implement.
            return array;
        }

        /// <summary>
        /// Inserts a new array element at the start.
        /// </summary>
        /// <param name="array">Input array.</param>
        /// <param name="number">Number to be added.</param>
        /// <returns>A new array with element added at a given index. If an array is empty or null, returns new array with number in it.</returns>
        public static int[] InsertFirst(int[] array, int number)
        {
            int adjustedArraySize = IsArrayTruthy(array) ? array.Length : 0;
            int[] results = new int[adjustedArraySize + 1];
            results[0] = number; 
            for (int i = 0; i < adjustedArraySize; i++)
            {
                results[i+1] = array[i];
            }
            return results;
        }

        /// <summary>
        /// Inserts a new array element at the end.
        /// </summary>
        /// <param name="array">Input array.</param>
        /// <param name="number">Number to be added.</param>
        /// <returns>A new array with element added in the end of array. If an array is empty or null, returns new array with number in it.</returns>
        public static int[] InsertLast(int[] array, int number)
        {
            int adjustedInputArrayLength = IsArrayTruthy(array) ? array.Length : 0;
            int[] results = new int[adjustedInputArrayLength + 1];
            for (int i = 0; i < adjustedInputArrayLength; i++)
            {
                results[i] = array[i];
            }
            results[adjustedInputArrayLength] = number;
            return results;
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
            if (!IsArrayTruthy(array)) return index == 0 ? new int[] { number } : new int[0];

            int[] results = new int[array.Length + 1];
            int adjustedInputIndex = (index + array.Length) % array.Length;
            for (int i = 0; i < array.Length; i++)
            {
                if (i < adjustedInputIndex) results[i] = array[i];
                else if (i > adjustedInputIndex) results[i] = array[i + 1];
                results[adjustedInputIndex] = number;
            }
            return results;
        }
    }
}
