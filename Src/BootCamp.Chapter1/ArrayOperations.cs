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
            if (!IsArrayNullOrEmpty(array))
            {
                int numberOfSwaps = 0;
                do
                {
                    numberOfSwaps = 0;
                    for (int i = 0; i < array.Length - 1; i++)
                    {
                        if (array[i] > array[i + 1])
                        {
                            int tempNumber = array[i + 1];
                            array[i + 1] = array[i];
                            array[i] = tempNumber;
                            numberOfSwaps += 1;
                        }
                    }
                } while (numberOfSwaps > 0);
            }
        }

        /// <summary>
        /// Reverse the array elements, first being last and so on.
        /// If array empty or null- don't do anything.
        /// </summary>
        /// <param name="array">Input array in a random order.</param>
        public static void Reverse(int[] array)
        {
            if (!IsArrayNullOrEmpty(array))
            {
                int[] tempArray = new int[array.Length];
                Array.Copy(array, 0, tempArray, 0, array.Length);

                for (int i = 0; i < array.Length; i++)
                {
                    array[i] = tempArray[tempArray.Length - 1 - i];
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
            if (!IsArrayNullOrEmpty(array))
            {
                int[] newArray = new int[array.Length - 1];

                for (int i = 0; i < newArray.Length; i++)
                {
                    newArray[i] = array[i];
                }
                return newArray;
            }
            else
            {
                return array;
            }
        }

        /// <summary>
        /// Remove first element in array.
        /// </summary>
        /// <returns>A new array with the first element removed. If an array is empty or null, returns input array.</returns>
        public static int[] RemoveFirst(int[] array)
        {
            if (!IsArrayNullOrEmpty(array))
            {
                int[] newArray = new int[array.Length - 1];

                for (int i = 0; i < newArray.Length; i++)
                {
                    newArray[i] = array[i + 1];
                }

                return newArray;
            }
            else
            {
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
            if (!IsArrayNullOrEmpty(array))
            {
                // Index out of bounds
                if (index < 0 || index >= array.Length)
                {
                    return array;
                }

                int[] newArray = new int[array.Length - 1];
                bool isRemoved = false;

                for (int i = 0; i < array.Length; i++)
                {
                    if (i == index)
                    {
                        isRemoved = true;
                        continue;
                    }
                    else if (isRemoved == true)
                    {
                        newArray[i-1] = array[i];
                    }
                    else
                    {
                        newArray[i] = array[i];
                    }
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

            /*
            if (IsArrayNullOrEmpty(array))
            {
                array = new int[] { number };
                return array;
            }
            else
            {
                int[] newArray = new int[array.Length + 1];

                newArray[0] = number;
                for (int i = 0; i < newArray.Length - 1; i++)
                {
                    newArray[i+1] = array[i];
                }
                return newArray;
            }
            */
        }

        /// <summary>
        /// Inserts a new array element at the end.
        /// </summary>
        /// <param name="array">Input array.</param>
        /// <param name="number">Number to be added.</param>
        /// <returns>A new array with element added in the end of array. If an array is empty or null, returns new array with number in it.</returns>
        public static int[] InsertLast(int[] array, int number)
        {
            int index;
            if (array == null)
            {
                index = 0;
            }
            else
            {
                index = array.Length;
            }
            return InsertAt(array, number, index);
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
            if (!IsArrayNullOrEmpty(array))
            {
                // Index out of bounds
                if (index < 0 || index > array.Length)
                {
                    return array;
                }

                int[] newArray = new int[array.Length + 1];
                bool isAdded = false;

                for (int i = 0; i < newArray.Length; i++)
                {
                    if (i == index)
                    {
                        newArray[i] = number;
                        isAdded = true;
                    }
                    else if (isAdded == true)
                    {
                        newArray[i] = array[i - 1];
                    }
                    else
                    {
                        newArray[i] = array[i];
                    }
                }
                return newArray;
            }
            else
            {
                if (index == 0)
                {
                    array = new int[1] { number };
                }
                return array;
            }
        }

        public static bool IsArrayNullOrEmpty(int[] array)
        {
            if ((array == null) || (array.Length == 0))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
