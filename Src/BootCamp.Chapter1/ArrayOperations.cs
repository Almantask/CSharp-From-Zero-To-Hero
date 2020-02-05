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
            if(array == null || array.Length < 2)
            {
                return;
            }
            for (int i = 0; i < array.Length - 1; ++i)
            {
                int mindex = i;
                for (int j = i; j < array.Length; ++j)
                {
                    if (array[j] < array[mindex])
                    {
                        mindex = j;
                    }
                }
                int temp = array[mindex];
                array[mindex] = array[i];
                array[i] = temp;
            }
            //selection sort

        }

        /// <summary>
        /// Reverse the array elements, first being last and so on.
        /// If array empty or null- don't do anything.
        /// </summary>
        /// <param name="array">Input array in a random order.</param>
        public static void Reverse(int[] array)
        {
            if(array.Length > 0)
            {
                for (int i = 0; i < array.Length / 2; ++i)
                {
                    int temp = array[i];
                    array[i] = array[array.Length-1-i];
                    array[array.Length-1 - i] = temp;
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
            return RemoveAt(array, array.Length - 1);
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
            if(array == null || array.Length < 1 || index < 0 || index > array.Length-1)
            {
                return array;
            }
            if (array.Length == 1)
            {
                return new int[] { };
            }
            int[] newArr = new int[array.Length - 1];
            for (int i = 0; i < array.Length-1; ++i)
            {
                newArr[i] = (i < index) ? array[i] : array[i + 1];
            }
            return newArr;
        }

        /// <summary>
        /// Inserts a new array element at the start.
        /// </summary>
        /// <param name="array">Input array.</param>
        /// <param name="number">Number to be added.</param>
        /// <returns>A new array with element added at a given index. If an array is empty or null, returns new array with number in it.</returns>
        public static int[] InsertFirst(int[] array, int number)
        {
            return InsertAt(array,number,0);
        }

        /// <summary>
        /// Inserts a new array element at the end.
        /// </summary>
        /// <param name="array">Input array.</param>
        /// <param name="number">Number to be added.</param>
        /// <returns>A new array with element added in the end of array. If an array is empty or null, returns new array with number in it.</returns>
        public static int[] InsertLast(int[] array, int number)
        {
            return InsertAt(array,number,array.Length-1);
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
            if (array != null && index >= 0 && index <= array.Length - 1)
            {
                int[] newArr = new int[array.Length + 1];
                newArr[index] = number;
                for (int i = 0; i < array.Length; ++i)
                {
                    if (i < index)
                    {
                        newArr[i] = array[i];
                    }
                    else {
                        newArr[i + 1] = array[i];
                    }
                }
                return newArr;
            }
            else if (index < 0 || index > array.Length - 1)
            {
                return array;
            }
            else
            {
                return new[] { number };
            }
               
        }
    }
}
