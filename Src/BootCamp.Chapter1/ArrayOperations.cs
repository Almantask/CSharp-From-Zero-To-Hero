using System;

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
            for (int i = 0; i < array.Length - 1; i++)
            {
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[i] > array[j])
                    {
                        int temp = array[j];
                        array[j] = array[i];
                        array[i] = temp;
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
            {
                return;
            }
            int arrSize = array.Length;
            for (int i = 0; i < arrSize / 2; i++)
            {
                int temp = array[i];
                array[i] = array[arrSize - i - 1];
                array[arrSize - i - 1] = temp;
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
            {
                return array;
            }

            int[] tempArr = new int[array.Length - 1];
            tempArr = RemoveAt(array, array.Length - 1);
            return tempArr;
        }

        /// <summary>
        /// Remove first element in array.
        /// </summary>
        /// <returns>A new array with the first element removed. If an array is empty or null, returns input array.</returns>
        public static int[] RemoveFirst(int[] array)
        {
            if (array == null || array.Length == 0)
            {
                return array;
            }

            int[] tempArr = new int[array.Length - 1];
            tempArr = RemoveAt(array, 0);
            return tempArr;
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
            {
                return array;
            }

            int[] tempArr = new int[array.Length - 1];
            int oldArrayIndex = 0;
            for(int i = 0; i < tempArr.Length; i++)
            {
                if(i == index)
                {
                    oldArrayIndex++;
                }
                tempArr[i] = array[oldArrayIndex];
                oldArrayIndex++;
            }
            return tempArr;
        }

        /// <summary>
        /// Inserts a new array element at the start.
        /// </summary>
        /// <param name="array">Input array.</param>
        /// <param name="number">Number to be added.</param>
        /// <returns>A new array with element added at a given index. If an array is empty or null, returns input array.</returns>
        public static int[] InsertFirst(int[] array, int number)
        {
            if (array == null || array.Length == 0)
            {
                return array;
            }

            int[] tempArr = new int[array.Length + 1];
            tempArr = InsertAt(array, number, 0);
            return tempArr;
        }

        /// <summary>
        /// Inserts a new array element at the end.
        /// </summary>
        /// <param name="array">Input array.</param>
        /// <param name="number">Number to be added.</param>
        /// <returns>A new array with element added in the end of array. If an array is empty or null, returns input array.</returns>
        public static int[] InsertLast(int[] array, int number)
        {
            if (array == null || array.Length == 0)
            {
                return array;
            }

            int[] tempArr = new int[array.Length + 1];
            tempArr = InsertAt(array, number, array.Length);
            return tempArr;
        }

        /// <summary>
        /// Inserts a new array element at the specified index.
        /// </summary>
        /// <param name="array">Input array.</param>
        /// <param name="number">Number to be added.</param>
        /// <param name="index">Index at which array element should be added.</param>
        /// <returns>A new array with element inserted at a given index. If an array is empty or null, returns input array.</returns>
        public static int[] InsertAt(int[] array, int number, int index)
        {
            if (array == null || array.Length == 0)
            {
                return array;
            }

            int[] tempArr = new int[array.Length + 1];
            int oldArrayIndex = 0;
            for (int i = 0; i < tempArr.Length; i++)
            {
                if (i == index)
                {
                    tempArr[i] = number;
                    i++;
                    if (index == array.Length)
                    {
                        return tempArr;
                    }
                }
                tempArr[i] = array[oldArrayIndex];
                oldArrayIndex++;
            }
            return tempArr;
        }
    }
}
