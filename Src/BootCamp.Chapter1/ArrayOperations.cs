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
            int temp;

            for (int i = 0; i < array.Length - 1; i++)
            {

                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array [i] > array[j])
                    {

                        temp = array[i];
                        array[i] = array[j];
                        array[j] = temp;

                    }

                }

            }
            foreach (int sort in array)
            Console.Write("{0} ", sort);
        }

        /// <summary>
        /// Reverse the array elements, first being last and so on.
        /// If array empty or null- don't do anything.
        /// </summary>
        /// <param name="array">Input array in a random order.</param>
        public static int[] Reverse(int[] array)
        {
            int temp;

            // traverse 0 to array length 
            for (int i = 0; i < array.Length - 1; i++)

                // traverse i+1 to array length 
                for (int j = i + 1; j < array.Length; j++)

                    // compare array element with  
                    // all next element 
                    if (array[i] < array[j])
                    {

                        temp = array[i];
                        array[i] = array[j];
                        array[j] = temp;
                    }

            // print all element of array 
            foreach (int value in array)
            {
                Console.Write(value + " ");
            }
            return array;
        }

        /// <summary>
        /// Remove last element in array.
        /// </summary>
        /// <param name="array">Input array.</param>
        /// <returns>A new array with the last element removed. If an array is empty or null, returns input array.</returns>
        public static int[] RemoveLast(int[] array)
        {
            var array2 = new int[array.Length - 1];

            for (int i = 0; i < array.Length - 1; i++)
            {
                array2[i] = array[i];
            }
            return array2;
        }

        /// <summary>
        /// Remove first element in array.
        /// </summary>
        /// <returns>A new array with the first element removed. If an array is empty or null, returns input array.</returns>
        public static int[] RemoveFirst(int[] array)
        {
            var array2 = new int[array.Length - 1];

            for (int i = 1; i < array.Length; i++)
            {
                array2[i] = array[i];
            }
            return array2;
        }

        /// <summary>
        /// Removes array element at given index.
        /// </summary>
        /// <param name="array">Input array.</param>
        /// <param name="index">Index at which array element should be removed.</param>
        /// <returns>A new array with element removed at a given index. If an array is empty or null, returns input array.</returns>
        public static int[] RemoveAt(int[] array, int index)
        {
            var array2 = new int[array.Length - 1];
            for (int i = 0; i != index; i++)
            {
                array2[i] = array[i];
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
            var array2 = new int[array.Length + 1];

            for (int i = 1; i < array.Length; i++)
            {
                array2[i] = array[i];
            }
            array2[0] = number;
            return array2;
        }

        /// <summary>
        /// Inserts a new array element at the end.
        /// </summary>
        /// <param name="array">Input array.</param>
        /// <param name="number">Number to be added.</param>
        /// <returns>A new array with element added in the end of array. If an array is empty or null, returns new array with number in it.</returns>
        public static int[] InsertLast(int[] array, int number)
        {
            var array2 = new int[array.Length + 1];
            
            for (int i = 0; i < array.Length; i++)
            {
                array2[i] = array[i];
            }
            array2[array2.Length] = number;
            return array2;
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
            var array2 = new int[array.Length - 1];
            for (int i = 0; i < array.Length -1; i++)
            {
                array2[i] = array[i];
            }
            array2[index] = number;
            return array2;
        }
    }
}