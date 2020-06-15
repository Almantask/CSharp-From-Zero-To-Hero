using System;
using System.IO;
using System.Threading;

namespace BootCamp.Chapter1
{
    public static class ArrayOperations
    {
        public static void Sort(int[] array)
        {
            if (array == null || array.Length == 0) return;
            
            // Bubble sort algorithm
            for (var i = 0; i < array.Length - 1; i++)
            {
                for (var j = i + 1; j < array.Length; j++)
                {
                    if (array[i] > array[j])
                    {
                        // Operation that swaps the two values only if they're incorrectly ordered
                        var temp = array[i];
                        array[i] = array[j];
                        array[j] = temp;
                    }
                }
            }
        }

        public static void Reverse(int[] array)
        {
            if (array == null || array.Length == 0) return;

            // Defines the start and end of the array.
            var startIndex = 0;
            var endIndex = array.Length - 1;

            // Over time, the start will increment by one index value
            // while the end decrements by one index value. Eventually 
            // these two values will pass each other which causes the
            // while loop to stop performing work.
            while (startIndex < endIndex)
            {
                // Performs a swap between the start and end value of the array.
                var temp = array[startIndex];
                array[startIndex] = array[endIndex];
                array[endIndex] = temp;

                // Increments start and end value until they meet
                startIndex += 1;
                endIndex -= 1;
            }

        }

        public static int[] RemoveLast(int[] array)
        {
            if (array == null || array.Length == 0)
            {
                return array;
            }
            return RemoveAt(array, array.Length - 1);
        }

        public static int[] RemoveFirst(int[] array)
        {
            if (array == null || array.Length == 0)
            {
                return array;
            }
            return RemoveAt(array,0);
        }

        public static int[] RemoveAt(int[] array, int index)
        {
            if (array == null || array.Length == 0)
            {
                return array;
            }

            // Defines the new array with the new length to accomodate the loss of a value.
            var newArray = new int[array.Length - 1];

            /// Elements right of item being inserted
            /// They are shifted back by one index value to fill in empty slot
            for (var i = index; i < array.Length - 1; i++)
            {

                newArray[i] = array[i + 1];
            }

            /// Elements left of the item that is being removed
            for (var i = 0; i < index; i++)
            {
                newArray[i] = array[i];
            }

            /// Item being removed

            return newArray;
        }

        public static int[] InsertFirst(int[] array, int number)
        {
            if (array == null || array.Length == 0)
            {
                var newArray = new[] { 0 };
                return newArray;
            }
            return InsertAt(array, number, 0);

        }

        public static int[] InsertLast(int[] array, int number)
        {
            if (array == null || array.Length == 0)
            {
                var newArray = new[] { 0 };
                return newArray;
            }
            return InsertAt(array, number, array.Length);
        }

        public static int[] InsertAt(int[] array, int number, int index)
        {
            if (array == null || array.Length == 0)
            {
                var makeNewArray = new[] { number };
                return makeNewArray;
            }

            var newArray = new int[array.Length + 1];

            /// Elements right of item being inserted
            /// They are shifted by one index value to make space
            for (var i = index; i < array.Length; i++)
            {

                newArray[i + 1] = array[i];
            }

            /// Elements left of the item that is being inserted
            for (var i = 0; i < index; i++)
            {
                newArray[i] = array[i];
            }

            /// Item being inserted
            newArray[index] = number;

            return newArray;
        }
    }
}
