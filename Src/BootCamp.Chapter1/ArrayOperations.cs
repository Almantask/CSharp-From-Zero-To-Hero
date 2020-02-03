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
            if (ArrayIsNullOrEmpty(array))
            {
                return;
            }

            BubbleSort(array);
        }

        /// <summary>
        /// check if an array is null or empty, returning true
        /// </summary>
        /// <param name="array">Input array.</param>
        private static bool ArrayIsNullOrEmpty(int[] array)
        {
            if (array == null || array.Length == 0)
            {
                return true;
            }

            return false;
        }

        /// <summary>
        /// Sort the array in ascending order with BubleSort method.
        /// </summary>
        /// <param name="array">Input array in a random order.</param>
        private static void BubbleSort(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                bool isSwapped = false;
                for (int j = 0; j < array.Length - 1; j++)
                {
                    if (array[j] > array[j + 1])
                    {
                        int temp = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = temp;
                        isSwapped = true;
                    }
                }

                if (!isSwapped)
                {
                    break;
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
            if (ArrayIsNullOrEmpty(array))
            {
                return;
            }

            int[] arrayCopy = new int[array.Length];
            CopyToArray(array, arrayCopy, 0, array.Length);
            int j = 0;

            for (int i = arrayCopy.Length - 1; i >= 0; i--)
            {
                array[j] = arrayCopy[i];
                j++;
            }
        }

        /// <summary>
        /// Copy a section of an array in the begining of another array
        /// </summary>
        /// <param name="arraySource">Input array source.</param>
        /// <param name="arrayDestination">destination array</param>
        /// <param name="start">Starting index</param>
        /// <param name="lenght">Lenght of new index</param>
        private static void CopyToArray(int[] arraySource, int[] arrayDestination, int start, int lenght)
        {
            if (start < 0 || lenght > arraySource.Length)
            {
                return;
            }

            int j = 0;
            for (int i = start; i < lenght; i++)
            {
                arrayDestination[j] = arraySource[i];
                j++;
            }
        }


        /// <summary>
        /// Remove last element in array.
        /// </summary>
        /// <param name="array">Input array.</param>
        /// <returns>A new array with the last element removed. If an array is empty or null, returns input array.</returns>
        public static int[] RemoveLast(int[] array)
        {
            if (ArrayIsNullOrEmpty(array))
            {
                return array;
            }
          
            return RemoveAt(array, array.Length - 1);
        }

        /// <summary>
        /// Remove first element in array.
        /// </summary>
        /// <returns>A new array with the first element removed. If an array is empty or null, returns input array.</returns>
        public static int[] RemoveFirst(int[] array)
        {
            if (ArrayIsNullOrEmpty(array))
            {
                return array;
            }

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
            if (ArrayIsNullOrEmpty(array))
            {
                return array;
            }
            if (index < 0 || index >= array.Length)
            {
                return array;
            }

            int j = 0;
            int[] auxArray = new int[array.Length - 1];

            for (int i = 0; i < array.Length; i++)
            {
                if (i == index)
                {
                    continue;
                }
                auxArray[j] = array[i];
                j++;
            }

            return auxArray;
        }

        /// <summary>
        /// Inserts a new array element at the start.
        /// </summary>
        /// <param name="array">Input array.</param>
        /// <param name="number">Number to be added.</param>
        /// <returns>A new array with element added at a given index. If an array is empty or null, returns new array with number in it.</returns>
        public static int[] InsertFirst(int[] array, int number)
        {
            if (ArrayIsNullOrEmpty(array))
            {
                return new [] { number };
            }

            int[] auxArray = new int[array.Length + 1];
            auxArray[0] = number;

            for (int i = 0; i < array.Length; i++)
            {
                auxArray[i + 1] = array[i];
            }
            return auxArray;
        }

        /// <summary>
        /// Inserts a new array element at the end.
        /// </summary>
        /// <param name="array">Input array.</param>
        /// <param name="number">Number to be added.</param>
        /// <returns>A new array with element added in the end of array. If an array is empty or null, returns new array with number in it.</returns>
        public static int[] InsertLast(int[] array, int number)
        {
            if (ArrayIsNullOrEmpty(array))
            {
                return new [] { number };
            }

            int[] auxArray = new int[array.Length + 1];
            auxArray[auxArray.Length - 1] = number;

            CopyToArray(array, auxArray, 0, array.Length);
            return auxArray;
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
            if (ArrayIsNullOrEmpty(array))
            {
                if (index != 0)
                {
                    return array;
                }
                return new [] { number };
            }

            if (index == 0)
            {
                return InsertFirst(array, number);
            }
            if (index == array.Length)
            {
                return InsertLast(array, number);
            }

            int[] auxArray = new int[array.Length + 1];
            int j = 0;
            int k = 0;

            for (int i = 0; i < auxArray.Length; i++)
            {
                if (j == index)
                {
                    auxArray[j] = number;
                    j++;
                    continue;
                }
                auxArray[j] = array[k];
                j++;
                k++;
            }


            return auxArray;
        }

        /// <summary>
        /// Print an array to console. if it is null or empty, it prints Empty.
        /// </summary>
        /// <param name="array"></param>
        public static void PrintArray(int[] array)
        {
            if (ArrayIsNullOrEmpty(array))
            {
                System.Console.WriteLine("Empty");
                return;
            }

            foreach (var item in array)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine("");
        }
    }
}
