using System;
using System.Collections.Generic;
using System.Text;
using Bootcamp.Optional;

namespace BootCamp.Chapter
{
    internal class Algorithm
    {
        /// <summary>
        /// This is used for testing only. Feel free to put test cases in.
        /// </summary>
        internal static void OptionalTestCases()
        {
            int swapCount = 0;
            int[] testArray = { 3, 2, 4, 1, 5 };
            Split(testArray, out int[] array1, out int[] array2);
            testArray = Merge(array1, array2);
            Utility.PrintArray(testArray);

            // This will print your array like "3, 2, 4, 1".
            // Utility.PrintArray(new int[] { 3, 2, 4, 1 });
        }

        /// <summary>
        /// This method will sort an array. Example: 3, 2, 4, 1 -> 1, 2, 3, 4
        /// </summary>
        /// <param name="array">The input array.</param>
        /// <param name="swapCount">The amount of swaps needed to this point. Use Utility.Swap() for swapping!</param>
        /// <returns>The sorted array.</returns>
        internal static int[] Sort(int[] array, ref int swapCount)
        {
            if (array.Length > 2)
            {
                Split(array, out int[] array1, out int[] array2);
                return Merge(Sort(array1, ref swapCount), Sort(array2, ref swapCount));
            }

            if (array.Length > 1 && array[0] > array[1])
            {
                // You need to use my Swap function for solving the challange.
                // It does nothing else than just swapping the two elements of index1 and index2 of the array.
                Utility.Swap(array, 0, 1, ref swapCount);
            }

            return array;
        }

        /// <summary>
        /// This function splits an array in two arrays.
        /// </summary>
        /// <param name="array">The input array.</param>
        /// <param name="array1">The (smaller) left side.</param>
        /// <param name="array2">The right side.</param>
        internal static void Split(int[] array, out int[] array1, out int[] array2)
        {
            array1 = new int[array.Length / 2];
            array2 = new int[array.Length / 2 + array.Length % 2];

            for (int i = 0; i < array1.Length; i++)
            {
                array1[i] = array[i];
                array2[i] = array[i + array1.Length];
            }
            array2[array2.Length - 1] = array[array1.Length + array2.Length - 1];
        }

        /// <summary>
        /// This function merges two arrays into one.
        /// </summary>
        /// <param name="array1">The left side.</param>
        /// <param name="array2">The right side.</param>
        /// <returns>The combination of left and right.</returns>
        internal static int[] Merge(int[] array1, int[] array2)
        {
            int[] array = new int[array1.Length + array2.Length];

            for (int i = 0; i < array1.Length; i++)
            {
                array[i] = array1[i];
            }

            for (int i = 0; i < array2.Length; i++)
            {
                array[i + array1.Length] = array2[i];
            }

            return array;
        }
    }
}
