using System;
namespace BootCamp.Chapter1
{
    public static class ArrayOperations
    {
        // *************private helpers**********
        /// <summary>
        /// Test that Array is neither null or empty.
        /// </summary>
        /// <returns>True if array can be manipulated by standard functions.</returns>
        /// 
        private static bool IsNullOrEmpty(int[] array)
        {
            return array == null || array.Length == 0;
        }
          
        /// <summary>
        /// Confirm thar the index to be modified exists.
        /// </summary>
        /// <returns>True if index is valid
        /// 
        private static bool IsIndexIsWithinRange(int[] array, string action, int index)
        {
            return action == "Remove" ? index < array.Length && index >= 0 : index <= array.Length && index >= 0;
        }

        //*************public array operations*************

        /// <summary>
        /// Sort the array in ascending order.
        /// If array empty or null- don't do anything.
        /// </summary>
        /// <param name="array">Input array in a random order.</param>
        public static void Sort(int[] array)
        {
            if (IsNullOrEmpty(array))
            { 
                return; 
            }
            // insertion sort
            
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

        /// <summary>
        /// Reverse the array elements, first being last and so on.
        /// If array empty or null- don't do anything.
        /// </summary>
        /// <param name="array">Input array in a random order.</param>
        public static void Reverse(int[] array)
        {
            if (!IsNullOrEmpty(array))
            {
                for (int i = 0; i < array.Length/2; i++)
                {
                    int tempHolder = array[i];
                    array[i] = array[array.Length - 1 - i];
                    array[array.Length - 1 - i] = tempHolder;
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
            if (array == null)
            {
                return array;
            }
            return RemoveAt(array, array.Length - 1);
        }
        
        /// <summary>
        /// Remove first element in array.
        /// </summary>
        /// <returns>A new array with the first element removed. If an array is empty or null, returns input array.</returns>
        /// 
        public static int[] RemoveFirst(int[] array)
        {
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
            if (!IsNullOrEmpty(array) && IsIndexIsWithinRange(array, "Remove", index))
            {
                var shortenedArray = new int[array.Length - 1]; ;

                for (int i = 0; i < shortenedArray.Length; i++)
                {
                shortenedArray[i] = i >= index ? array[i + 1] : array[i];
                }
                return shortenedArray;
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
            return InsertAt(array, number, 0);
        }

        /// <summary>
        /// Inserts a new array element at the end.
        /// </summary>
        /// <param name="array">Input array.</param>
        /// <param name="number">Number to be added.</param>
        /// <returns>A new array with element added in the end of array. If an array is empty or null, returns new array with number in it.</returns>
        
        public static int[] InsertLast(int[] array, int number)
        {
            if (array == null)
            {
                return new[] { number };
            }
            return InsertAt(array, number, array.Length);
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
            if (IsIndexIsWithinRange(array, "Insert", index))
            {
                var lengthenedArray = new int[array.Length + 1];

                //place the new number at the desired index
                lengthenedArray[index] = number; 

                // place all the original array numbers in their original position. 
                //when we get to the new index placement, offsetting position of the old array positions by one
                for (int i = 0; i < lengthenedArray.Length - 1; i++)
                {
                    if (i >= index)
                    {
                        lengthenedArray[i + 1] = array[i];
                    }
                    else
                    {
                        lengthenedArray[i] = array[i];
                    }
                }
                return lengthenedArray;
            }
            return array;
        }
    }
}
