using System.Runtime.CompilerServices;

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
                int temp;

                for (int i = 0; i < array.Length - 1; i++)
                {
                    for (int j = (i + 1); j < array.Length; j++)
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
                int[] reverseArray = new int[array.Length];

                for (int i = 0; i < array.Length; i++)
                {
                    reverseArray[i] = array[array.Length - (i + 1)];
                }

                for (int i = 0; i < array.Length; i++)
                {
                    array[i] = reverseArray[i];
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
            if (array != null && array.Length > 0)
            {
                int[] arrayWithoutLastIndex = new int[array.Length - 1];
                for (int i = 0; i < array.Length - 1; i++)
                {
                    arrayWithoutLastIndex[i] = array[i];
                }
                return arrayWithoutLastIndex;
            }

            return array;
        }

        /// <summary>
        /// Remove first element in array.
        /// </summary>
        /// <returns>A new array with the first element removed. If an array is empty or null, returns input array.</returns>
        public static int[] RemoveFirst(int[] array)
        {
            if (array != null && array.Length > 0)
            {
                int[] arrayWithoutLastIndex = new int[array.Length - 1];
                for (int i = array.Length - 2; i >= 0; i--)
                {
                    arrayWithoutLastIndex[i] = array[i + 1];
                }
                return arrayWithoutLastIndex;
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
            if (array != null && array.Length > 0 && index >= 0 && index < array.Length)
            {
                int[] arrayWithoutSpecifiedIndex = new int[array.Length - 1];
                for (int i = 0; i < array.Length - 1; i++)
                {
                    if (i >= index)
                    {
                        arrayWithoutSpecifiedIndex[i] = array[i + 1];
                    }
                    else
                    {
                        arrayWithoutSpecifiedIndex[i] = array[i];
                    }
                }

                return arrayWithoutSpecifiedIndex;
            }
            return array;
        }
        // public void int testMethod{"<>"}
        /// <summary>
        /// Inserts a new array element at the start.
        /// </summary>
        /// <param name="array">Input array.</param>
        /// <param name="number">Number to be added.</param>
        /// <returns>A new array with element added at a given index. If an array is empty or null, returns new array with number in it.</returns>
        public static int[] InsertFirst(int[] array, int number)
        {
            int[] arrayAddFirstIndex = array == null ? new int[1] : new int[array.Length + 1];

            arrayAddFirstIndex[0] = number;
            for (int i = 0; i < (array == null ? 0 : array.Length) ; i++)
            {
                arrayAddFirstIndex[i + 1] = array[i];
            }

            return arrayAddFirstIndex;
        }

        /// <summary>
        /// Inserts a new array element at the end.
        /// </summary>
        /// <param name="array">Input array.</param>
        /// <param name="number">Number to be added.</param>
        /// <returns>A new array with element added in the end of array. If an array is empty or null, returns new array with number in it.</returns>
        public static int[] InsertLast(int[] array, int number)
        {
            int[] arrayAddLastIndex = array == null ? new int[1] : new int[array.Length + 1];

            arrayAddLastIndex[array == null ? 0 : (arrayAddLastIndex.Length - 1)] = number;

            for (int i = 0; i < (array == null ? 0 : array.Length); i++)
            {
                arrayAddLastIndex[i] = array[i];
            }

            return arrayAddLastIndex;
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
            // ToDo: implement.
            return array;
        }
    }
}
