namespace BootCamp.Chapter1
{
    public static class ArrayOperations
    {
        /// <summary>
        /// Checks if array is null or empty
        /// </summary>
        /// <param name="array"></param>
        /// <returns>true or false</returns>
        public static bool IsNullOrEmpty(int[] array)
        {
            if(array == null || array.Length == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        /// <summary>
        /// Sort the array in ascending order.
        /// If array empty or null- don't do anything.
        /// </summary>
        /// <param name="array">Input array in a sorted order.</param>
        public static void Sort(int[] array)
        {
            if(IsNullOrEmpty(array))
            {
                return;
            }

            for (int i = 0; i < array.Length; i++)
            {
                for(int j = i + 1; j < array.Length; j++)
                {
                    if(array[i] > array[j])
                    {
                        int temp = array[i];
                        array[i] = array[j];
                        array[j] = temp;
                    }
                }
        
            }
        }

        /// <summary>
        /// Reverse the array elements, first being last and so on.
        /// If array empty or null- don't do anything.
        /// </summary>
        /// <param name="array">Input array in a reversed order.</param>
        public static void Reverse(int[] array)
        {
            if (IsNullOrEmpty(array))
            {
                return;
            }

            for (int i = 0; i < array.Length/2; i++)
            {
                int temp = array[i];
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
            if (IsNullOrEmpty(array))
            {
                return array;
            }

            return RemoveAt(array, array.Length - 1);
        }

        /// <summary>
        /// Remove first element in array.
        /// </summary>
        /// <returns>A new array with the first element removed. If an array is empty or null, returns input array.</returns>
        public static int[] RemoveFirst(int[] array)
        {
            if (IsNullOrEmpty(array))
            {
                return array;
            }

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
            if (IsNullOrEmpty(array))
            {
                return array;
            }
            // Check if index is within length of array
            if (index < 0 || index >= array.Length)
            {
                return array;
            }

            var new_array = new int[array.Length - 1];
            for (int i = 0; i < array.Length - 1; i++)
            {
                if (i < index)
                {
                    new_array[i] = array[i];
                }
                else
                {
                    new_array[i] = array[i + 1];
                }
            }
            return new_array;
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
            return InsertAt(array, number, array.Length);
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
            if (IsNullOrEmpty(array))
            {
                if (index == 0)
                {
                    array = new int[] { number };
                    return array;

                }
                else
                {
                    return array;
                }
            }

            if (index < 0 || index > array.Length)
            {
                return array;
            }

            var new_array = new int[array.Length + 1];
            new_array[index] = number;
            for (int i = 0; i < array.Length; i++)
            {
                if (i < index)
                {
                    new_array[i] = array[i];
                }
                else
                {
                    new_array[i + 1] = array[i];
                }
            }
            return new_array;

        }
    }
}
