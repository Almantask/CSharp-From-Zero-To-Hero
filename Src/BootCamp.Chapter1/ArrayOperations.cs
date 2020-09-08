using System;
using System.Collections;

namespace BootCamp.Chapter1
{
    public static class ArrayOperations
    {
        /// <summary>
        /// Sort the array in ascending order.
        /// If array empty or null- don't do anything.
        /// </summary>
        /// <param name="array">Input array in a random order.</param>
        public static void Sort(int[] array)
        {
            if (array?.Length > 0) Array.Sort(array);
        }

        /// <summary>
        /// Reverse the array elements, first being last and so on.
        /// If array empty or null- don't do anything.
        /// </summary>
        /// <param name="array">Input array in a random order.</param>
        public static void Reverse(int[] array)
        {
            if (array?.Length > 0) Array.Reverse(array);
        }

        /// <summary>
        /// Remove last element in array.
        /// </summary>
        /// <param name="array">Input array.</param>
        /// <returns>A new array with the last element removed. If an array is empty or null, returns input array.</returns>
        public static int[] RemoveLast(int[] array)
        {
            if (array?.Length > 0)
            {
                int[] output = new int[array.Length - 1];
                for (int i = 0; i < output.Length; i++)
                {
                    output[i] = array[i];
                }
                return output;
            }
            return array;
        }

        /// <summary>
        /// Remove first element in array.
        /// </summary>
        /// <returns>A new array with the first element removed. If an array is empty or null, returns input array.</returns>
        public static int[] RemoveFirst(int[] array)
        {
            if (array?.Length > 0)
            {
                int[] output = new int[array.Length - 1];
                for (int i = 0; i < output.Length; i++)
                {
                    output[i] = array[i + 1];
                }
                return output;
            }
            return array;
        }

        /// <summary>
        /// Removes array element at given index.
        /// </summary>
        /// <param name="array">Input array.</param>
        /// <param name="index">Index at which array element should be removed.</param>
        /// <returns>A new array with element removed at a given index. If an array is empty or null, returns input array.</returns>
        public static int[] RemoveAt(int[] array, int index)
        {
            if (index < 0 || index >= array?.Length)
            {
                return array;
            }
            if (index == 0)
            {
                return RemoveFirst(array);
            }
            if (array?.Length > 0)
            {
                int[] output = new int[array.Length - 1];
                int flag = 0;
                for (int i = 0; i < output.Length; i++)
                {
                    if (i == index)
                    {
                        flag = 1;
                    }
                    output[i] = array[i + flag];
                }
                return output;
            }
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
            if (array?.Length > 0)
            {
                int[] output = new int[array.Length + 1];
                output[0] = number;
                for (int i = 1; i < output.Length; i++)
                {
                    output[i] = array[i - 1];
                }
                return output;
            }
            return new int[] { number };
        }

        /// <summary>
        /// Inserts a new array element at the end.
        /// </summary>
        /// <param name="array">Input array.</param>
        /// <param name="number">Number to be added.</param>
        /// <returns>A new array with element added in the end of array. If an array is empty or null, returns new array with number in it.</returns>
        public static int[] InsertLast(int[] array, int number)
        {
            if (array?.Length > 0)
            {
                int[] output = new int[array.Length + 1];
                output[output.Length - 1] = number;
                for (int i = 0; i < output.Length - 1; i++)
                {
                    output[i] = array[i];
                }
                return output;
            }
            return new int[] { number };
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
            if (array?.Length > 0)
            {
                int[] output = new int[array.Length + 1];
                int flag = 0;
                for (int i = 0; i < output.Length - 1; i++)
                {
                    if (i == index)
                    {
                        output[i] = number;
                        flag = 1;
                        continue;
                    }
                    output[i + flag] = array[i];
                }
                return output;
            }
            if (index == 0)
            {
                return new int[] { number };
            }
            return array;
        }
    }
}
