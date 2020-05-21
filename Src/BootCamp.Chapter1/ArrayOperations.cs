using System;
using System.Diagnostics;
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
            if (array == null || array.Length == 0) return;
            int result = 0;
            for (var i = 0; i < array.Length - 1; i++)
            {
                for (var j = i + 1; j < array.Length; j++)
                {
                    if (array[j] < array[i])
                    {
                        result = array[i];
                        array[i] = array[j];
                        array[j] = result;
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
            if (array == null || array.Length == 0) return;
            Array.Reverse(array);
            for (var i = 0; i < array.Length / 2; i++)
            {
                var temp = array[i];
            }
        }

        /// <summary>
        /// Remove last element in array.
        /// </summary>
        /// <param name="array">Input array.</param>
        /// <returns>A new array with the last element removed. If an array is empty or null, returns input array.</returns>
        public static int[] RemoveLast(int[] array)
        {
            return array;
        }

        /// <summary>
        /// Remove first element in array.
        /// </summary>
        /// <returns>A new array with the first element removed. If an array is empty or null, returns input array.</returns>
        public static int[] RemoveFirst(int[] array)
        {
            // ToDo: implement.
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
            if (array == null || array.Length <= 0 || index == -1 || array.Length <= index) return array;
            
            var tempArray = array.Length - 1;
            var arrayIndex = new int[tempArray];

            for (var i = 0; i < tempArray; i++)
            {
                if (i < array.Length)
                    arrayIndex[i] = array[i];
                if (i >= index)
                    arrayIndex[i] = array[i + 1];

            }
            return arrayIndex;
        }

        /// <summary>
        /// Inserts a new array element at the start.
        /// </summary>
        /// <param name="array">Input array.</param>
        /// <param name="number">Number to be added.</param>
        /// <returns>A new array with element added at a given index. If an array is empty or null, returns new array with number in it.</returns>
        public static int[] InsertFirst(int[] array, int number)
        {
            // ToDo: implement.
            return array;
        }

        /// <summary>
        /// Inserts a new array element at the end.
        /// </summary>
        /// <param name="array">Input array.</param>
        /// <param name="number">Number to be added.</param>
        /// <returns>A new array with element added in the end of array. If an array is empty or null, returns new array with number in it.</returns>
        public static int[] InsertLast(int[] array, int number)
        {
            // ToDo: implement.
            return array;
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
            if (array == null || array.Length == 0)
            {
                if (array != null && array.Length == 0 && index != 0)
                {
                    return array;
                }

                int[] newArray = new[] {number};
                return newArray;
            }
      
            var tempArray = new int[array.Length + 1];
                     
            for (var i = 0; i < array.Length; i++)
            {
                if (i < index)
                    tempArray[i] = array[i];
                else if (i == index)
                    tempArray[i] = number;
                else
                    tempArray[i] = array[i - 1];
            }
            
            return tempArray;
            
        }
    }
}

