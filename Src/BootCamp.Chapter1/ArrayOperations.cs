using System;

namespace BootCamp.Chapter1
{
    public static class ArrayOperations
    {
        private static void SwapElements(int[] array, int index, int j)
        {
            int aux = array[index];
            array[index] = array[j];
            array[j] = aux;
        }

        private static int GetPartitionNumber(int[] array, int low, int high)
        {
            int pivotNumber = array[high];
            int index = low - 1;

            for (int j = low; j <= high - 1; j++)
            {
                if (array[j] < pivotNumber)
                {
                    index += 1;
                    SwapElements(array, index, j);
                }
            }

            SwapElements(array, index + 1, high);
            return index + 1;
        }

        private static void Quicksort(int[] array, int lowIndex, int highIndex)
        {
            if (lowIndex < highIndex)
            {
                int pivotNumber = GetPartitionNumber(array, lowIndex, highIndex);
                Quicksort(array, lowIndex, pivotNumber - 1);
                Quicksort(array, pivotNumber + 1, highIndex);
            }

        }

        /// <summary>
        /// Sort the array in ascending order.
        /// If array empty or null- don't do anything.
        /// </summary>
        /// <param name="array">Input array in a random order.</param>
        public static void Sort(int[] array)
        {
            if (array != null && array.Length > 0)
            {
                Quicksort(array, 0, array.Length - 1);
            }
        }

        /// <summary>
        /// Reverse the array elements, first being last and so on.
        /// If array empty or null- don't do anything.
        /// </summary>
        /// <param name="array">Input array in a random order.</param>
        public static void Reverse(int[] array)
        {
            if (array != null && array.Length > 0)
            {
                for (int i = 0; i <= (array.Length / 2) - 1; i++)
                {
                    int j = array.Length - 1 - i;
                    SwapElements(array, i, j);
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

            if (array == null || array.Length == 0)
            {
                return array;
            }

            int[] result = new int[array.Length - 1];
            for (int i = 0; i < result.Length; i++)
            {
                result[i] = array[i];
            }
            return result;
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

            int[] result = new int[array.Length - 1];
            for (int i = result.Length - 1; i >= 0; i--)
            {
                result[i] = array[i + 1];
            }
            return result;
        }

        /// <summary>
        /// Removes array element at given index.
        /// </summary>
        /// <param name="array">Input array.</param>
        /// <param name="index">Index at which array element should be removed.</param>
        /// <returns>A new array with element removed at a given index. If an array is empty or null, returns input array.</returns>
        public static int[] RemoveAt(int[] array, int index)
        {
            if (array != null && array.Length > 0 && index < array.Length && index >= 0)
            {
                int j = 0;
                int[] result = new int[array.Length - 1];

                for (int i = 0; i < result.Length; i++)
                {
                    if (index == i)
                        j++;

                    result[i] = array[j];
                    j++;
                }

                return result;
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

            return array == null || array.Length == 0 ? new int[] { number } : InsertAt(array, number, 0);

        }

        /// <summary>
        /// Inserts a new array element at the end.
        /// </summary>
        /// <param name="array">Input array.</param>
        /// <param name="number">Number to be added.</param>
        /// <returns>A new array with element added in the end of array. If an array is empty or null, returns new array with number in it.</returns>
        public static int[] InsertLast(int[] array, int number)
        {
            return array == null || array.Length == 0 ? InsertAt(array, number, 0) : InsertAt(array, number, array.Length);
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

            if (array == null)
            {
                return new[] { number };
            }
            else
            {
                if (array.Length == 0)
                    return index == 0 ? new[] { number } : array;

                if (index < 0 || index > array.Length)
                    return array;

                int[] result = new int[array.Length + 1];
                int j = 0;

                for (int i = 0; i < result.Length; i++)
                {
                    if (i == index)
                    {
                        result[i] = number;
                    }
                    else
                    {
                        result[i] = array[j];
                        j++;
                    }
                }

                return result;
            }


        }
    }
}
