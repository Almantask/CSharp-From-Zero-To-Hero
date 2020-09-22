using System;
using System.Globalization;
using System.Linq;

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
            if (array != null)
            {
                if(array.Length != 0)
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
            if (array != null)
            {
                if (array.Length != 0)
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
            if (array != null)
            {
                if (array.Length != 0)
                {
                    var lastRemoved = new int[array.Length - 1];
                    for (int i = 0; i < array.Length - 1; i++)
                    {
                        lastRemoved[i] = array[i];
                    }
                    return lastRemoved;
                }
            }
            return array;
        }

        /// <summary>
        /// Remove first element in array.
        /// </summary>
        /// <returns>A new array with the first element removed. If an array is empty or null, returns input array.</returns>
        public static int[] RemoveFirst(int[] array)
        {
            if (array != null)
            {
                if(array.Length != 0)
                {
                    var firstRemoved = new int[array.Length - 1];
                    for (int i = 1; i < array.Length; i++)
                    {
                        firstRemoved[i - 1] = array[i];
                    }
                    return firstRemoved;
                }
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
            if (array != null)
            {
                if(array.Length != 0 && index >= 0 && index <= array.Length - 1)
                {
                    if (index == 0)
                        return RemoveFirst(array);
                    else if (index == array.Length - 1)
                        return RemoveLast(array);
                    else
                    {
                        var elementRemoved = new int[array.Length - 1];
                        for (int i = 0; i < index; i++)
                        {
                            elementRemoved[i] = array[i];
                        }
                        for (int i = index; i < array.Length-1; i++)
                        {
                            elementRemoved[i] = array[i + 1];
                        }
                        return elementRemoved;
                    }
                }
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
            if (array != null)
            {
                if(array.Length != 0)
                {
                    var newArray = new int[array.Length + 1];
                    newArray[0] = number;
                    for (int i = 0; i < array.Length; i++)
                    {
                        newArray[i + 1] = array[i];
                    }
                    return newArray;
                }
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
            if (array != null)
            {
                if(array.Length != 0)
                {
                    var newArray = new int[array.Length + 1];
                    for (int i = 0; i < array.Length; i++)
                    {
                        newArray[i] = array[i];
                    }
                    newArray[newArray.Length - 1] = number;
                    return newArray;
                }
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
            if (array != null)
            {
                if (array.Length != 0)
                {
                    if (index >= 0 && index <= array.Length - 1)
                    {

                        var newArray = new int[array.Length + 1];
                        for (int i = 0; i < index; i++)
                        {
                            newArray[i] = array[i];
                        }
                        newArray[index] = number;
                        for (int i = index + 1; i < array.Length - 1; i++)
                        {
                            newArray[i] = array[i];
                        }
                        return newArray;
                    }
                    return new int[0];
                }
                if (index < 0 || index > array.Length)
                    return new int[0];
            }
            return new int[] { number };
        }
    }
}
