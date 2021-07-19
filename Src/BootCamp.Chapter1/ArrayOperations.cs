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
        public static int[] RemoveLast(int[] array)
        {
            if (array == null || array.Length == 0)
            {
                return array;
            }
            else
            {
                var type = array.GetType().IsArray;

                if (type)
                {

                    var length = array.Length - 1;
                    List<int> numbers = new List<int>(array);
                    numbers.RemoveAt(length);
                    array = numbers.ToArray();
             
                    return array;
                        
                }
                else
                {
                    return array;
                }
            }
        }


        /// <summary>
        /// Remove first element in array.
        /// </summary>
        /// <returns>A new array with the first element removed. If an array is empty or null, returns input array.</returns>
        public static int[] RemoveFirst(int[] array)
        {
            if (array == null || array.Length == 0)
            {
                return array;
            }
            else
            {
                var type = array.GetType().IsArray;

                if (type)
                {

                    List<int> numbers = new List<int>(array);
                    numbers.RemoveAt(0);
                    array = numbers.ToArray();

                    return array;

                }
                else
                {
                    return array;
                }


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
            if (array == null || array.Length == 0)
            {
                return array;
            }
            else
            {
                if(index >= 0 && index < array.Length)
                {
                    var type = array.GetType().IsArray;


                    if (type)
                    {

                        List<int> numbers = new List<int>(array);
                        numbers.RemoveAt(index);
                        array = numbers.ToArray();

                        return array;

                    }
                    else
                    {
                        return array;
                    }
                }
                else
                {
                    return array;
                }           
            }
        }

        /// <summary>
        /// Inserts a new array element at the start.
        /// </summary>
        /// <param name="array">Input array.</param>
        /// <param name="number">Number to be added.</param>
        /// <returns>A new array with element added at a given index. If an array is empty or null, returns new array with number in it.</returns>
        public static int[] InsertFirst(int[] array, int number)
        {
            if (array != null)
            {
                var type = array.GetType().IsArray;
                if (type)
                {
                    List<int> numbers = new List<int>(array);
                    numbers.Insert(0, number);
                    array = numbers.ToArray();

                    return array;
                }
                else
                {
                    int[] myArray = new int[] { number };
                    return myArray;
                }
            }
            else
            {
                int[] myArray = new int [] { number };
                return myArray;
            }
        }
        /// <summary>
        /// Inserts a new array element at the end.
        /// </summary>
        /// <param name="array">Input array.</param>
        /// <param name="number">Number to be added.</param>
        /// <returns>A new array with element added in the end of array. If an array is empty or null, returns new array with number in it.</returns>
        public static int[] InsertLast(int[] array, int number)
        {
            if (array != null)
            {
                var type = array.GetType().IsArray;
                var length = array.Length;
                if (type)
                {
                    List<int> numbers = new List<int>(array);
                    numbers.Insert(length, number);
                    array = numbers.ToArray();

                    return array;
                }
                else
                {
                    int[] myArray = new int[] { number };
                    return myArray;
                }
            }
            else
            {
                int[] myArray = new int[] { number };
                return myArray;
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
            if (array != null)
            {
                if(array.Length != 0)
                {
                    var type = array.GetType().IsArray;
                    if (type)
                    {
                        List<int> numbers = new List<int>(array);
                        numbers.Insert(index, number);
                        array = numbers.ToArray();

                        return array;
                    }
                    else
                    {
                        return array;
                    }
                }
                else if(array.Length == 0 && index == 0)
                {
                    int[] myArray = new int[] { number };
                    return myArray;
                }
                else
                {
                    return array;
                }
                
            }
            else
            {
                int[] myArray = new int[] { number };
                return myArray;
            }
        }

    }
}
