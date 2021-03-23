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
            {
                for (var i = 0; i < array.Length - 1; i++)
                {
                    if (array[i] > array[i + 1])
                    {
                        int x = array[i];
                        array[i] = array[i + 1];
                        array[i + 1] = x;
                        i = -1;
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
                for (var i = 0; i < array.Length /2; i++)
                {
                    int x = array[i];
                    array[i] = array[array.Length - 1 - i ];
                    array[array.Length - 1 - i] = x;

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
            if(array != null)
            {
                return RemoveAt(array, array.Length - 1);
            }
            return array;

        }

        /// <summary>
        /// Remove first element in array.
        /// </summary>
        /// <returns>A new array with the first element removed. If an array is empty or null, returns input array.</returns>
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
            if ((array !=null && array.Length>0) && (index >=0 && index < array.Length))
            {
                int[] newArray = new int[array.Length-1];

                int j = 0;
                for (var i=0;i<newArray.Length;i++)
                {
                    if(i==index)
                    {
                        j++;
                    }
                    newArray[i] = array[j];
                    j++;
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
            if ((array != null && array.Length >= 1))
            {
                return InsertAt(array, number, array.Length);
            }
            else
            {
                int[] newArray = new int[] { number };
                return newArray;
            }    
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
            int[] newArray;

            //check if array is null && length is greater than 0
            if ((array != null && array.Length > 0))
            {                
                newArray = new int[array.Length + 1];
                int j = 0;
                for (var i=0;i<newArray.Length;i++)
                {
                    
                    if (i == index)
                    {
                        newArray[i] = number;                        
                        continue;
                    }                    
                    newArray[i] = array[j];
                    j++;
                }               
                return newArray;
            }

            //check if index is greater than 0 and less than or equal to the length of the array
            else if(array == null || (index >=0 && index <= array.Length))
            {
                Console.WriteLine("Array is NUll");
                newArray = new int[] { number };
                return newArray;
            }

            return array;
        }
    }
}
