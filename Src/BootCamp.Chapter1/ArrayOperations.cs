using System;
using System.Reflection;

namespace BootCamp.Chapter1
{
    public static class ArrayOperations
    {

        //Swap operation
        private static void Swap(int[] array, int index)
        {
            if (array.Length > (index + 1))
            {
                var temp = array[index];
                array[index] = array[index + 1];
                array[index + 1] = temp;
            }
        }

        //Print array
        private static void Print(int[] array)
        {
            foreach (var num in array)
            {
                Console.Write(num + ",");
            }
        }

        /// <summary>
        /// Sort the array in ascending order.
        /// If array empty or null- don't do anything.
        /// </summary>
        /// <param name="array">Input array in a random order.</param>
        public static void Sort(int[] array)
        {
            if ((array != null) && (array.Length != 0))
            {
                // Print(array);
                //Console.WriteLine(Environment.NewLine);
                for (var j = 0; j < array.Length - 1; j++)
                {
                    //Console.WriteLine("j:"+j);
                    for (var i = 0; i < array.Length - 1 - j; i++)
                    {
                        //Console.WriteLine("i:"+i);
                        if (array[i] > array[i + 1])
                        {
                            Swap(array, i);
                        }
                        else if (array[i] == array[i + 1])
                        {
                            continue;
                        }
                        // Print(array);
                        //Console.WriteLine(Environment.NewLine);
                    }
                }

            }

        }

        public static void ReverseArr(int[] arr, int i, int j)
        {
            if (i >= j) return;
            int temp = arr[i];
            arr[i] = arr[j];
            arr[j] = temp;
            ReverseArr(arr, ++i, --j);
        }

        /// <summary>
        /// Reverse the array elements, first being last and so on.
        /// If array empty or null- don't do anything.
        /// </summary>
        /// <param name="array">Input array in a random order.</param>
        public static void Reverse(int[] array)
        {
            if ((array != null) && (array.Length != 0))
            {
                if(array.Length == 1)
                {
                    return;
                }
                //Recursive function to swap first and last element.
                ReverseArr(array, 0, array.Length-1);

            }
        }

        /// <summary>
        /// Remove last element in array.
        /// </summary>
        /// <param name="array">Input array.</param>
        /// <returns>A new array with the last element removed. If an array is empty or null, returns input array.</returns>
        public static int[] RemoveLast(int[] array)
        {
            if (array != null && array.Length > 0)
            {
                int[] tempArray = new int[array.Length - 1];
                for (var i = 0; i < tempArray.Length; i++)
                {
                    tempArray[i] = array[i];
                }
                return tempArray;
            }
            return array;
        }

        /// <summary>
        /// Remove first element in array.
        /// </summary>
        /// <returns>A new array with the first element removed. If an array is empty or null, returns input array.</returns>
        public static int[] RemoveFirst(int[] array)
        {
            if (array != null && array.Length > 0)
            {
                if(array.Length == 1) return new int[0];
                if (array.Length == 2) return new int[1] { array[1] };
                int[] tempArray = new int[array.Length - 1];
                for (var i = 0; i < tempArray.Length; i++)
                {
                    tempArray[i] = array[i+1];
                }
                return tempArray;
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
            
            if(array == null || array.Length == 0)
            {
                return array;
            }

            //If array has only one element, then remove the based on the index value.
            //Index is 1, then pass new empty array.
            //if in index is other than 1, index is out of bounds so return the original array.
            if(array.Length == 1)
            {
                if(index == 1 ) return new int[0];
                return array;
            }

            //Scenario where array length is >1
            int[] tempArray = new int[array.Length - 1];

            //if index is invalid then, return the original array.
            if (index < 0) return array;
            
            //if index is 0, then 
            if (index == 0) return RemoveFirst(array);

            //Scenario where index is >= length of the array
            if (index >= array.Length) return array;

            //other scenario's for removing indexed element from the array
            int j = 0;
            for(int i = 0; i < array.Length; ++i)
            {
                //index matches with iteration, continue the execution.
                if(i == index)
                {
                    continue;
                }
                tempArray[j] = array[i];
                j++;
            }
          
            return tempArray;
        }

        /// <summary>
        /// Inserts a new array element at the start.
        /// </summary>
        /// <param name="array">Input array.</param>
        /// <param name="number">Number to be added.</param>
        /// <returns>A new array with element added at a given index. If an array is empty or null, returns new array with number in it.</returns>
        public static int[] InsertFirst(int[] array, int number)
        {
            if (array == null || array.Length == 0) return new int[] { number };

            int[] tempArray = new int[array.Length + 1];
            tempArray[0] = number;
            for(int i = 0; i < array.Length; ++i)
            {
                tempArray[i + 1] = array[i];
            }
            return tempArray;
        }

        /// <summary>
        /// Inserts a new array element at the end.
        /// </summary>
        /// <param name="array">Input array.</param>
        /// <param name="number">Number to be added.</param>
        /// <returns>A new array with element added in the end of array. If an array is empty or null, returns new array with number in it.</returns>
        public static int[] InsertLast(int[] array, int number)
        {
            if (array == null || array.Length == 0) return new int[] { number };
               
            int[] tempArray = new int[array.Length + 1];
            for (var i = 0; i < array.Length; i++)
            {
                    tempArray[i] = array[i];
            }
            tempArray[array.Length] = number; 
            return tempArray;
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
            if ((array == null) || (array.Length == 0))
            {
                if (index == 0) return new int[] { number };
                return array;
            }

            int[] tempArray = new int [array.Length + 1];
            if(index < 0) return array;
            if(index == 0) return InsertFirst(array, number);

            int j = 0;
            for (int i = 0; i < tempArray.Length; ++i)
            {
                if (i == index)
                {
                    tempArray[i] = number;
                    j = i;
                    continue;
                }
                tempArray[i] = array[j];
                j++;
            }
            return tempArray;
        }
    }
}
