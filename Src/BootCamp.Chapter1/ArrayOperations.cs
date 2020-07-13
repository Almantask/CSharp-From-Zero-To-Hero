using System;
using System.Linq.Expressions;

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
            // ToDo: implement.
            if (array == null)
            {
                return;
            }
            int integer;
            for(int i=0; i<array.Length-1; i++)
            {
                for(int j=i+1; j<array.Length; j++)
                {
                    if (array[i] > array[j])
                    {
                        integer = array[i];
                        array[i] = array[j];
                        array[j] = integer;
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
            // ToDo: implement.
            if(array == null)
            {
                return;
            }
            int integer; 
            for(int i=0; i<array.Length / 2; i++)
            {
                integer = array[i];
                array[i] = array[array.Length - i - 1];
                array[array.Length - i - 1] = integer;
            }
        }

        /// <summary>
        /// Remove last element in array.
        /// </summary>
        /// <param name="array">Input array.</param>
        /// <returns>A new array with the last element removed. If an array is empty or null, returns input array.</returns>
        public static int[] RemoveLast(int[] array)
        {
            // ToDo: implement.
            if (array == null)
            {
                return null;
            }
            else if (array.Length == 0)
            {
                return array;
            }
            int[] newArray = new int[array.Length - 1];
            for (int i = 0; i < array.Length - 1; i++)
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
            // ToDo: implement.
            if (array == null)
            {
                return null;
            }
            else if (array.Length == 0)
            {
                return array;
            }
            int[] newArray = new int[array.Length - 1];
            for (int i = 1; i <= array.Length - 1 ; i++) 
            {
                newArray[i-1] = array[i];
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
            // ToDo: implement.
            if (array == null)
            {
                return null;
            }
            else if ((index > array.Length -1) || (index < 0))
            {
                return array;
            }
            int[] newArray = new int[array.Length - 1];
            for ( int i = 0; i < index; i++)
            {
                newArray[i] = array[i];
            }
            for (int i = index +1; i <= array.Length-1; i++)
            {
                newArray[i-1] = array[i];
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
            // ToDo: implement.
            int[] nullarray = { number };
            if (array == null)
            {
                return nullarray;
            }
            int[] newArray = new int[array.Length + 1];
            newArray[0] = number;
            for (int i = 1; i <= array.Length ; i++)
            {
                newArray[i] = array[i-1];
            }
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
            // ToDo: implement.
            int[] nullarray = { number };
            if (array == null)
            {
                return nullarray;
            }
            int[] newArray = new int[array.Length + 1];
            for (int i = 0; i <= newArray.Length -2; i++)
            {
                newArray[i] = array[i];
            }
            newArray[^1] = number;
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
            // ToDo: implement.
            int[] nullArray = { number };
            if (array == null)
            {
                return nullArray;
            }
            else if ((index > array.Length) || (index < 0))
            {
                return array;
            }
            else if (array.Length == 0)
            {
                return nullArray;
            }
            int[] newArray = new int[array.Length + 1];
            for (int i = 0; i < index; i++)
            {
                newArray[i] = array[i];
            }
            newArray[index] = number;
            for(int i = 1+ index; i<newArray.Length; i++)
            {
                newArray[i] = array[i-1];
            }
            return newArray;
        }
    }
}
