using System;
using System.Collections;
using System.Collections.Immutable;
using System.Reflection.Metadata.Ecma335;

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
            if (array == null || array.Length == 0) { return; }
            else
            {
                int temp = 0;

                for (int i = 0; i < array.Length - 1; i++)
                {
                    for (int j = i + 1; j < array.Length; j++)
                    {
                        if (array[i] > array[j])
                        {
                            temp = array[i];
                            array[i] = array[j];
                            array[j] = temp; 
                        }
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
            if (array == null || array.Length == 0) { return; }
            else
            {
                var array2 = new int[array.Length];

                for (int i = 0; i < array.Length / 2; i++)
                {
                    int temp = array[i];
                    array[i] = array[array.Length - i - 1];
                    array[array.Length - i - 1] = temp;
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
            

            if (array == null || array.Length == 0) { return array; }
            else
            {
                var array2 = new int[array.Length - 1];
                Array.Copy(array, array2, array2.Length);
                 

                return array2;
            }

            
        }

        /// <summary>
        /// Remove first element in array.
        /// </summary>
        /// <returns>A new array with the first element removed. If an array is empty or null, returns input array.</returns>
        public static int[] RemoveFirst(int[] array)
        {
            if (array == null || array.Length == 0) { return array; }
            if (array.Length == 1)
            {
                var emptyArray = new int[0];               
                return emptyArray;
            }
            else
            {
                var array2 = new int[array.Length - 1];
                Array.Copy(array, array[1], array2, array2[0], array2.Length);
                return array2;
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
            if (array == null || array.Length == 0) { return array; }
            if (index < 0 || index > array.Length - 1) { return array; }
            if (index == 1 && array.Length == 2)
            {
               var array2 = new int[array.Length - 1];
               Array.Copy(array, array2, array2.Length);
                return array2;
            }
            if (index == 0)
            {
                var array2 = new int[array.Length - 1];
                Array.Copy(array, array[1], array2, array2[index], array2.Length);
                return array2;
            }
            else
            {
                var array3 = new int[array.Length];

                for (int i = 0; i < array.Length; i++)
                {
                    if (i == index)
                    {
                        array3[i] = array[i + 1];
                    }

                    else if (i <= index)
                    {
                        array3[i] = array[i];
                    }

                    else
                    {
                        array3[i - 1] = array[i];
                    }

                }
              
                Array.Resize(ref array3, array.Length - 1);
           
                return array3;
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
            if (array == null || array.Length == 0)
            {
                var array2 = new int[1] { number };
                return array2; 
            }
            else
            {
                var array2 = new int[array.Length + 1];

                for (int i = 0; i < array.Length; i++)
                {
                    array2[i + 1] = array[i];
                }
                array2[0] = number;
                return array2;
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
            if (array == null || array.Length == 0)
            {
                var array2 = new int[1] { number };
                return array2;
            }
            else
            {
                var array2 = new int[array.Length + 1];

                for (int i = 0; i < array.Length; i++)
                {
                    array2[i] = array[i];
                }
                array2[array2.Length - 1] = number;
                return array2;
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
           
            if (array == null || array.Length == 0)
            {   
    
                if (index < 0) { return array; }
                if ((index > 0) && (array == null || array.Length == 0)) { return array;}
                else if (number > 0 && index >= 0)
                {
                    var array2 = new int[1] { number };
                    return array2;
                }
            }
            if (index > array.Length) { return array; }
            else
            {
                var array2 = new int[array.Length + 1];
                int temp = 0;
                for(int i = 0; i < array.Length; i++)
                    {
                        if (i == index)
                        {
                            temp = array[i];
                            array2[i] = number;
                            array2[i + 1] = temp;
                        }
                        if (i < index)
                        {
                            array2[i] = array[i];
                        }
                        if (i > index)
                        {
                            array2[i + 1] = array[i];
                        }
                    }
                return array2;

            }
        }

    }
}
