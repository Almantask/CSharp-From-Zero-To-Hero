﻿namespace BootCamp.Chapter1
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

            if (array == null)
            {
                return;
            }

            var flag = true;
            var temp = 0;
            int numLength = array.Length; 

            //sorting an array  
            for (var i = 1; (i <= (numLength - 1)) && flag; i++)
            {
                flag = false;
                for (var j = 0; j < (numLength - 1); j++)
                {
                    if (array[j + 1] < array[j])
                    {
                        temp = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = temp;
                        flag = true;
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
            var stop = 0;

            if (array == null)
            {
                return;
            }
            
            stop = array.Length / 2;
            
            for (var i = 0; i < stop; i++)
            {
                var temp = array[i];
                array[i] = array[array.Length - i - 1];
                array[array.Length - i - 1] = temp;
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
            var newArray = ProcessArray(array, array.Length - 1);
            return newArray;
        }

        /// <summary>
        /// Remove first element in array.
        /// </summary>
        /// <returns>A new array with the first element removed. If an array is empty or null, returns input array.</returns>
        public static int[] RemoveFirst(int[] array)
        {
            var newArray = ProcessArray(array, 0);
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
            var newArray = ProcessArray(array, index);
            return newArray;
        }

        private static int[] ProcessArray(int[] array, int index)
        {
            var isValid = IsValidCase(array, index);

            if (!isValid)
            {
                return array;
            }

            array = Remove(array, index);
            return array;
        }

        private static bool IsValidCase(int[] array, int index)
        {
            if (array == null) 
            {
                return false;
            }

            if (index < 0 || index == array.Length || array.Length == 0 || index > array.Length)
            {
                return false; 
            }

            return true;
        }

        private static int[] Remove(int[] array, int index)
        {
            var newArray = new int[array.Length - 1];

            for (int i = 0; i <= array.Length - 1; i++)
            {
                if (i < index)
                {
                    // copy the orginal content
                    newArray[i] = array[i];
                } else if (i > index)
                {
                    //  because the index is now 1 to high for the new index , we copy it to a index 1 lower
                    newArray[i - 1] = array[i];
                }
            }

            return newArray;
        }

        /// <summary>
        /// Inserts a new array element at the start.
        /// </summary>
        /// <param name="array">Input array.</param>
        /// <param name="number">Number to be added.</param>
        /// <returns>A new array with element added at a given index. If an array is empty or null, returns input array.</returns>
        public static int[] InsertFirst(int[] array, int number)
        {
            if (array == null)
            {
                return new [] { number };
            }

            var newArray = InsertAt(array, number, 0);
            return newArray;
        }

        /// <summary>
        /// Inserts a new array element at the end.
        /// </summary>
        /// <param name="array">Input array.</param>
        /// <param name="number">Number to be added.</param>
        /// <returns>A new array with element added in the end of array. If an array is empty or null, returns input array.</returns>
        public static int[] InsertLast(int[] array, int number)
        {
            if (array == null)
            {
               return new [] { number };
            }

            var newArray = InsertAt(array, number, array.Length) ;
            newArray[newArray.Length - 1] = number; 
            return newArray;
        }

        /// <summary>
        /// Inserts a new array element at the specified index.
        /// </summary>
        /// <param name="array">Input array.</param>
        /// <param name="number">Number to be added.</param>
        /// <param name="index">Index at which array element should be added.</param>
        /// <returns>A new array with element inserted at a given index. If an array is empty or null, returns input array.</returns>
        public static int[] InsertAt(int[] array, int number, int index)
        {

            if (!IsValidCaseForInsertForInValidIndex(array, index))
            {
                return array;
            }

            if (! IsValidCaseForInsertForNullOrEmpty(array, number, index)  )
            {
                if (index == 0)
                {
                    return new [] { number };
                }
                return array; 
            }

           
            
            var newArray = Insert(array, number, index);

            return newArray;

        }

        public static bool IsValidCaseForInsertForInValidIndex(int[] array, int index)
        {
            if (index >= 0)
            {
                return true;  
            }
            return false; 
        } 
           
        
            

        public static bool  IsValidCaseForInsertForNullOrEmpty(int[] array, int number, int index)
        {
            if (array == null || array.Length == 0)
            {
                return false; 
            }

            return true; 
        }

        public static int[] Insert(int[] array,  int number, int index)
        {
            var newArray = new int[array.Length + 1]; 
            for (int i = 0; i <= array.Length - 1; i++)
            {
                if (i < index)
                {
                    // copy the orginal content
                    newArray[i] = array[i];
                }
                else if (i > index)
                {
                    //  because the index is now 1 to high for the new index , we copy it to a index 1 higher
                    newArray[i + 1] = array[i];
                }
                else
                {
                    //we have the new element
                    newArray[i] = number;
                }
            }

            return newArray; 
        }
    }
}
