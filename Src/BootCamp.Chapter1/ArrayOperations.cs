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
            if (array != null)
            // insertion sort
            {
                for (int i = 1; i < array.Length; i++)
                {
                    int index = array[i]; int j = i;
                    while (j > 0 && array[j - 1] > index)
                    {
                        array[j] = array[j - 1];
                        j--;
                    }
                    array[j] = index;
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

                int[] tempArray = new int[array.Length];

                for (int i = 0; i < array.Length; i++)
                {
                    tempArray[i] = array[i];
                }
                for (int i = 0; i < array.Length; i++)
                {
                    array[i] = tempArray[array.Length - 1 - i];
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
            if (array == null) { return array; }
            if (array.Length != 0)
            {
                int[] shortenedArray = new int[array.Length - 1];
                for (int i = 0; i < shortenedArray.Length; i++)
                {
                    shortenedArray[i] = array[i];
                }
                array = shortenedArray;
            }
            return array;
        }
        /// <summary>
        /// Remove first element in array.
        /// </summary>
        /// <returns>A new array with the first element removed. If an array is empty or null, returns input array.</returns>
        public static int[] RemoveFirst(int[] array)
        {
            if (array == null) { return array; }
            if (array.Length != 0)
            {
                int[] shortenedArray = new int[array.Length - 1];
                for (int i = 0; i < shortenedArray.Length; i++)
                {
                    shortenedArray[i] = array[i+1];
                }
                array = shortenedArray;
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
            
            if (array == null) { return array; }
            if ((index >= array.Length)||(index<0)) { return array; }
            if (array.Length != 0)
            {
                int[] shortenedArray = new int[array.Length - 1];
                for (int i = 0; i < shortenedArray.Length; i++)
                {
                    if (i >= index)
                    { shortenedArray[i] = array[i + 1]; }
                    else { shortenedArray[i] = array[i]; }
                }
                array = shortenedArray;
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
            // ToDo: implement.
            return array;
        }
    }
}
