using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;

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
            if (array == null || array.Length == 0)
                return;

            int temp = 0;

            for (int i = 0; i <= array.Length - 1; i++)
            {
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[i] > array[j])
                    {
                        temp = array[i];
                        array[i] = array[j];
                        array[j] = temp;
                    }
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
            if (array == null || array.Length == 0)
                return;

            for (int i = 0; i < array.Length / 2; i++)
            {
                int tmp = array[i];
                array[i] = array[array.Length - i - 1];
                array[array.Length - i - 1] = tmp;
            }
        }

        /// <summary>
        /// Remove last element in array.
        /// </summary>
        /// <param name="array">Input array.</param>
        /// <returns>A new array with the last element removed. If an array is empty or null, returns input array.</returns>
        public static int[] RemoveLast(int[] array)
        {
            if (array == null || array.Length == 0)
                return array;
            int index = array.Length - 1;
            return RemoveAt(array, index);
        }

        /// <summary>
        /// Remove first element in array.
        /// </summary>
        /// <returns>A new array with the first element removed. If an array is empty or null, returns input array.</returns>
        public static int[] RemoveFirst(int[] array)
        {
            if (array == null || array.Length == 0)
                return array;
            int index = 0;
            return RemoveAt(array, index);
        }

        /// <summary>
        /// Removes array element at given index.
        /// </summary>
        /// <param name="array">Input array.</param>
        /// <param name="index">Index at which array element should be removed.</param>
        /// <returns>A new array with element removed at a given index. If an array is empty or null, returns input array.</returns>
        public static int[] RemoveAt(int[] array, int index)
        {
            if (array == null || array.Length == 0)
                return array;
            var array2 = new int[array.Length - 1];

            if (index > array2.Length || index < 0)
            {
                return array;
            }

            for (var i = 0; i < array2.Length; i++)
            {
                if (i < index)
                {
                    array2[i] = array[i];
                }
                else
                {
                    array2[i] = array[i + 1];
                }
            }
            return array2;
        }


        /// <summary>
        /// Inserts a new array element at the start.
        /// </summary>
        /// <param name="array">Input array.</param>
        /// <param name="number">Number to be added.</param>
        /// <returns>A new array with element added at a given index. If an array is empty or null, returns new array with number in it.</returns>
        public static int[] InsertFirst(int[] array, int number)
        {
            int index = 0;
            return InsertAt(array, number, index);
        }

        /// <summary>
        /// Inserts a new array element at the end.
        /// </summary>
        /// <param name="array">Input array.</param>
        /// <param name="number">Number to be added.</param>
        /// <returns>A new array with element added in the end of array. If an array is empty or null, returns new array with number in it.</returns>
        public static int[] InsertLast(int[] array, int number)
        {
            if (array == null || array.Length == 0)
            {
                int[] newArray = new int[] { number };
                for (int i = 0; i < newArray.Length; i++)
                {
                    Console.WriteLine(newArray[i]);
                }
                return newArray;
            }
            else
                return InsertAt(array, number, array.Length);
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

            if ((array == null || array.Length == 0) && index == 0)
            {
                int[] newArray = new int[] { number };
                return newArray;
            }
            else if (index > 0 && array.Length == 0)
            {
                return array;
            }
            else if (index < 0)
            {
                return array;
            }
            else
            {
                var array2 = new int[array.Length + 1];

                for (var i = 0; i < array2.Length; i++)
                {
                    if (i < index)
                    {
                        array2[i] = array[i];
                    }
                    else if (i == index)
                    {
                        array2[i] = number;
                    }
                    else
                    {
                        array2[i] = array[i - 1];
                    }
                }
                return array2;
            }
        }
    }
}
