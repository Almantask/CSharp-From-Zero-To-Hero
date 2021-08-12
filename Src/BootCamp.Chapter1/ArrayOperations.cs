﻿using System;

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
            if (array != null && array.Length != 0)
            {
                Array.Sort(array);
            }
        }

        /// <summary>
        /// Reverse the array elements, first being last and so on.
        /// If array empty or null- don't do anything.
        /// </summary>
        /// <param name="array">Input array in a random order.</param>
        public static void Reverse(int[] array)
        {
            // ToDo: implement.
            if (array != null && array.Length != 0)
            {
                Array.Reverse(array);
            }
        }

        /// <summary>
        /// Remove last element in array.
        /// </summary>
        /// <param name="array">Input array.</param>
        /// <returns>A new array with the last element removed. If an array is empty or null, returns input array.</returns>
        public static int[] RemoveLast(int[] array)
        {
            // Returns input array if array is empty of null.
            if (array == null || array.Length == 0) return array;

            // Returns array minus last element.
            int[] new_array = new int[array.Length - 1];
            for (int i = 0; i < array.Length - 1; i++)
            {
                new_array[i] = array[i];
            }
            return new_array;
        }

        /// <summary>
        /// Remove first element in array.
        /// </summary>
        /// <returns>A new array with the first element removed. If an array is empty or null, returns input array.</returns>
        public static int[] RemoveFirst(int[] array)
        {
            // ToDo: implement.
            // Returns input array if array is empty of null.
            if (array == null || array.Length == 0) return array;

            // Returns array minus last element.
            int[] new_array = new int[array.Length - 1];
            for (int i = 0; i < array.Length - 1; i++)
            {
                new_array[i] = array[i+1];
            }
            return new_array;

        }

        /// <summary>
        /// Removes array element at given index.
        /// </summary>
        /// <param name="array">Input array.</param>
        /// <param name="index">Index at which array element should be removed.</param>
        /// <returns>A new array with element removed at a given index. If an array is empty or null, returns input array.</returns>
        public static int[] RemoveAt(int[] array, int index)
        {
            // Returns input array if array is empty of null.
            if (array == null || array.Length == 0) return array;

            // Return input array if index is out of array's range
            if (index < 0 || index > array.Length-1) return array;

            int i = 0;
            int j = 0;
            int[] new_array = new int[array.Length - 1];
            // Returns array minus last element.
            while (i < array.Length)
            {
                if (array[i] != index)
                {
                    new_array[j] = array[i];
                    j++;
                }
                i++;
            }
            return new_array;
        }

        /// <summary>
        /// Inserts a new array element at the start.
        /// </summary>
        /// <param name="array">Input array.</param>
        /// <param name="number">Number to be added.</param>
        /// <returns>A new array with element added at a given index. If an array is empty or null, returns new array with number in it.</returns>
        public static int[] InsertFirst(int[] array, int number)
        {
            // Returns new number array if array is empty of null.
            if (array == null || array.Length == 0) return new int[1] { number };

            // Create new array with an extra slot
            int[] new_array = new int[array.Length + 1];

            // If at first position, add the number, else add value from old array - 1
            for (int i = 0; i < new_array.Length; i++)
            {
                if (i == 0)
                {
                    new_array[0] = number;
                }
                else new_array[i] = array[i-1];
            }
            return new_array;
        }

        /// <summary>
        /// Inserts a new array element at the end.
        /// </summary>
        /// <param name="array">Input array.</param>
        /// <param name="number">Number to be added.</param>
        /// <returns>A new array with element added in the end of array. If an array is empty or null, returns new array with number in it.</returns>
        public static int[] InsertLast(int[] array, int number)
        {
            // Returns new number array if array is empty of null.
            if (array == null || array.Length == 0) return new int[1] { number };

            // Create new array with an extra slot
            int[] new_array = new int[array.Length + 1];

            // If at last position, add the number, else add value from old array
            for (int i = 0; i < new_array.Length; i++)
            {
                if (i == array.Length)
                {
                    new_array[i] = number;
                }
                else new_array[i] = array[i];
            }
            return new_array;
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
            // When array == null return number
            if (array == null) return new int[1] { number };
            if (array.Length == 0)
            {
                if (index < 0 || index > array.Length) return array;
                else return new int[1] { number };
            }

            // Create new array with an extra slot
            int[] new_array = new int[array.Length + 1];

            // If at given position, add the number, else add value from old array
            for (int i = 0; i < array.Length+1; i++)
            {
                if(i < index)
                {
                    new_array[i] = array[i];
                }
                else if (i == index)
                {
                    new_array[i] = number;
                }
                else
                {
                    new_array[i] = array[i - 1];
                }
            }
            return new_array;
        }
    }
}
