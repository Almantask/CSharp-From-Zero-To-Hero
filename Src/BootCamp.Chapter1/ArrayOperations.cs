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
            if (array != null && array.Length != 0) Array.Sort(array);
        }

        private static int[] CopyIntArray(int[] array)
        {
            var newArray = new int[array.Length];
            for (var i = 0; i < array.Length; i++)
            {
                newArray[i] = array[i];
            }

            return newArray;
        }
        
        /// <summary>
        /// Reverse the array elements, first being last and so on.
        /// If array empty or null- don't do anything.
        /// </summary>
        /// <param name="array">Input array in a random order.</param>
        public static void Reverse(int[] array)
        {
            if (array == null || array.Length == 0) return;
            int[] arrayCopy = CopyIntArray(array);
            for (var i = 0; i < array.Length; i++)
            {
                array[i] = arrayCopy[^(i+1)];
            }
        }

        /// <summary>
        /// Remove last element in array.
        /// </summary>
        /// <param name="array">Input array.</param>
        /// <returns>A new array with the last element removed. If an array is empty or null, returns input array.</returns>
        public static int[] RemoveLast(int[] array)
        {
            if (array == null || array.Length == 0) return array;
            var newArray = new int[array.Length - 1];
            for (var i = 0; i < newArray.Length; i++)
            {
                newArray[i] = array[i];
            }
            return newArray;
        }

        /// <summary>
        /// Remove first element in array.
        /// </summary>
        /// <returns>A new array with the first element removed. If an array is empty or null, returns input array.</returns>
        public static int[] RemoveFirst(int[] array)
        {
            if (array == null || array.Length == 0) return array;
            var newArray = new int[array.Length - 1];
            for (var i = 0; i < newArray.Length; i++)
            {
                newArray[i] = array[i+1];
            }
            return newArray;
        }

        /// <summary>
        /// Removes array element at given index.
        /// </summary>
        /// <param name="array">Input array.</param>
        /// <param name="index">Index at which array element should be removed.</param>
        /// <returns>A new array with element removed at a given index. If an array is empty or null, returns input array.</returns>
        public static int[] RemoveAt(int[] array, int index)
        {
            if (array == null || array.Length == 0) return array;
            if (index < 0 || index >= array.Length) return array;
            var newArray = new int[array.Length-1];
            var isRemoved = false;
            for (var i = 0; i < array.Length; i++)
            {
                if (!isRemoved && i == index) isRemoved = true;
                if (isRemoved && i < array.Length-1) newArray[i] = array[i+1];
                if (!isRemoved) newArray[i] = array[i];
            }
            return newArray;
        }

        /// <summary>
        /// Inserts a new array element at the start.
        /// </summary>
        /// <param name="array">Input array.</param>
        /// <param name="number">Number to be added.</param>
        /// <returns>A new array with element added at a given index. If an array is empty or null, returns new array with number in it.</returns>
        public static int[] InsertFirst(int[] array, int number)
        {
            if (array == null || array.Length == 0) return new int[] {number};
            
            var newArray = new int[array.Length + 1];
            newArray[0] = number;
            for (var i = 0; i < array.Length; i++) newArray[i + 1] = array[i];
            return newArray;
        }

        /// <summary>
        /// Inserts a new array element at the end.
        /// </summary>
        /// <param name="array">Input array.</param>
        /// <param name="number">Number to be added.</param>
        /// <returns>A new array with element added in the end of array. If an array is empty or null, returns new array with number in it.</returns>
        public static int[] InsertLast(int[] array, int number)
        {
            if (array == null || array.Length == 0) return new[] {number};
            
            var newArray = new int[array.Length + 1];
            newArray[^1] = number;
            for (var i = 0; i < array.Length; i++) newArray[i] = array[i];
            return newArray;
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
            if (array == null) return new[] {number};
            if (index > array.Length || index < 0) return array;
            if (array.Length == 0) return new[] {number};
            var newArray = new int[array.Length + 1];
            newArray[index] = number;
            for (var i = 0; i < array.Length; i++)
            {
                if (i == index) continue;
                newArray[i] = array[i];
            }
            return newArray;
        }
    }
}
