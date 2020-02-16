//using System;

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
            if (array == null || array.Length == 0)
            {
                return;
            }

            var arrayLength = array.Length;
            // loop through all elements
            for (var i = 0; i < arrayLength; i++)
            {
                // compare element on current index to all next elements
                for (var j = i + 1; j < arrayLength; j++)
                {
                    // keep swapping till lowest is found
                    if (array[i] > array[j])
                    {
                        var tmp = array[i];
                        array[i] = array[j];
                        array[j] = tmp;

                        //Console.WriteLine("Swapping: " + array[j] + " and " + array[i]);
                        //Console.Write("Changed result: ");
                        //foreach (var number in array)
                        //{
                        //    Console.Write(number + " ");
                        //}
                        //Console.Write(Environment.NewLine);
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

            var arrayLength = array.Length;
            // make a copy of array by value (not reference)
            int[] tmp = new int[128];
            for (var i = 0; i < arrayLength; i++)
            {
                tmp[i] = array[i];
            }

            // reverse current index with last index reduced with current index
            for (var i = 0; i < arrayLength; i++)
            {
                //Console.WriteLine("Swapping: " + array[i] + " and " + tmp[arrayLength - i-1]);
                array[i] = tmp[arrayLength - i-1];
            }
        }

        /// <summary>
        /// Remove last element in array.
        /// </summary>
        /// <param name="array">Input array.</param>
        /// <returns>A new array with the last element removed. If an array is empty or null, returns input array.</returns>
        public static int[] RemoveLast(int[] array)
        {
            if (array != null && array.Length != 0)
            {
                var arrayLength = array.Length;
                int[] newArray = new int[arrayLength - 1];
                // make a copy of array by value (not reference) and skip last
                for (var i = 0; i < newArray.Length; i++)
                {
                        newArray[i] = array[i];
                }
                return newArray;
            }
            return array;
        }

        /// <summary>
        /// Remove first element in array.
        /// </summary>
        /// <returns>A new array with the first element removed. If an array is empty or null, returns input array.</returns>
        public static int[] RemoveFirst(int[] array)
        {
            if (array != null && array.Length != 0)
            {
                var arrayLength = array.Length;
                int[] newArray = new int[arrayLength - 1];
                // make a copy of array by value (not reference) and skip first
                for (var i = 0; i < newArray.Length; i++)
                {
                    newArray[i] = array[i+1];
                }
                return newArray;
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
            if (array != null && array.Length != 0)
            {
                var arrayLength = array.Length;
                if (index < 0 || index >= arrayLength)
                {
                    return array;
                }

                int[] newArray = new int[arrayLength - 1];
                var removedIndex = 0;
                // make a copy of array by value (not reference) and count/add if index is removed
                for (var i = 0; i < newArray.Length; i++)
                {
                    if (i == index)
                    {
                        removedIndex = 1;
                    }
                    newArray[i] = array[i+removedIndex];
                }
                return newArray;
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
            if (array != null && array.Length != 0)
            {
                var arrayLength = array.Length;
                int[] newArray = new int[arrayLength + 1];
                // insert first element manually and copy existing elements
                newArray[0] = number;
                for (var i = 0; i < arrayLength; i++)
                {
                    newArray[i+1] = array[i];
                }
                return newArray;
            }
            else
            {
                var newArray = new[] { number };
                return newArray;
            }
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
            if (array != null && array.Length != 0)
            {
                var arrayLength = array.Length;
                int[] newArray = new int[arrayLength + 1];
                // copy existing elements and add last element
                for (var i = 0; i < arrayLength; i++)
                {
                    newArray[i] = array[i];
                }
                newArray[arrayLength] = number;
                return newArray;
            }
            else
            {
                var newArray = new[] { number };
                return newArray;
            }
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
            if (array != null && array.Length != 0)
            {
                var arrayLength = array.Length;
                if (index < 0 || index > arrayLength)
                {
                    return array;
                }

                int[] newArray = new int[arrayLength + 1];
                var addedIndex = 0;
                // make a copy of array by value (not reference) and count/add if index added
                for (var i = 0; i < arrayLength; i++)
                {
                    if (i == index)
                    {
                        newArray[i] = number;
                        addedIndex = 1;
                    }
                    newArray[i + addedIndex] = array[i];
                }
                return newArray;
            } else
            {
                // if array is null or 0, declare new array with the number at position 0
                if (index == 0)
                {
                    var newArray = new[] { number };
                    return newArray;
                }
            }
            return array;
        }
    }
}
