using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;

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
            if(array == null)
            {
                Console.WriteLine(array);
            }
            else
            {
                Array.Sort(array);
                foreach (int value in array)

                    Console.Write(value);
            }
            
        }

        /// <summary>
        /// Reverse the array elements, first being last and so on.
        /// If array empty or null- don't do anything.
        /// </summary>
        /// <param name="array">Input array in a random order.</param>
        public static void Reverse(int[] array)
        {
            if (array == null)
            {
                Console.WriteLine(array);
            }
            else
            {
                Array.Reverse(array);
                foreach (int value in array)

                    Console.Write(value);
            }

        }

        /// <summary>
        /// Remove last element in array.
        /// </summary>
        /// <param name="array">Input array.</param>
        /// <returns>A new array with the last element removed. If an array is empty or null, returns input array.</returns>
        public static object RemoveLast(int[] array)
        {
            
            if (array != null || array.Length != 0)
            {
                var type = array.GetType().IsArray;

                if(type)
                {
                    if(array.Length == 1)
                {
                        var length = 0;
                        List<int> numbers = new List<int>(array);
                        numbers.RemoveAt(numbers.IndexOf(length));
                        array = numbers.ToArray();
                    }
                else
                    {
                        var length = array.Length - 1;
                        List<int> numbers = new List<int>(array);
                        numbers.RemoveAt(numbers.IndexOf(length));
                        array = numbers.ToArray();
                    }
                }

            }
            else
            {
                return array;
            }

                
                return array;
            }
            
    
        /// <summary>
        /// Remove first element in array.
        /// </summary>
        /// <returns>A new array with the first element removed. If an array is empty or null, returns input array.</returns>
        public static int[] RemoveFirst(int[] array)
        {
            if (array == null)
            {
                return array;
            }
            else
            {
                
                Array.Clear(array, 1 , 1);

                return array;
            }

            
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
