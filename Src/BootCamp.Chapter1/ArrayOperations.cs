namespace BootCamp.Chapter1
{
    public static class ArrayOperations
    {

        static bool IsArraySorted(int[] array)
        {
            for (int i = 0; i < array.Length - 1; i++)
            {
                if (array[i] > array[i + 1])
                {
                    return false;
                }
            }
            return true;
        }
        /// <summary>
        /// Sort the array in ascending order.
        /// If array empty or null- don't do anything.
        /// </summary>
        /// <param name="array">Input array in a random order.</param>
        public static void Sort(int[] array)
        {
            if (IsArrayNullOrEmpty(array))
            {
                return;
            }

            while (!IsArraySorted(array))
            {
                for (int i = 0; i < array.Length - 1; i++)
                {
                    if (array[i] > array[i + 1])
                    {
                        var smaller = array[i + 1];
                        array[i + 1] = array[i];
                        array[i] = smaller;
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
            if (IsArrayNullOrEmpty(array))
            {
                return;
            }

            for (int i = 0; i < array.Length / 2 ; i++)
            {
                var foo = array[i];
                array[i] = array[array.Length - 1 - i];
                array[array.Length - 1 - i] = foo;
            }
        }

        /// <summary>
        /// Remove last element in array.
        /// </summary>
        /// <param name="array">Input array.</param>
        /// <returns>A new array with the last element removed. If an array is empty or null, returns input array.</returns>
        public static int[] RemoveLast(int[] array)
        {
            if (IsArrayNullOrEmpty(array))
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
            if (IsArrayNullOrEmpty(array))
            {
                return array;
            }

            return RemoveAt(array,0);
        }

        /// <summary>
        /// Removes array element at given index.
        /// </summary>
        /// <param name="array">Input array.</param>
        /// <param name="index">Index at which array element should be removed.</param>
        /// <returns>A new array with element removed at a given index. If an array is empty or null, returns input array.</returns>
        public static int[] RemoveAt(int[] array, int index)
        {
            if (IsArrayNullOrEmpty(array))
            {
                return array;
            }
            if (index >= array.Length || index < 0)
            {
                return array;
            }

            var amendedArray = new int[array.Length - 1];
            for (int i = 0; i < array.Length - 1; i++)
            {
                if (i >= index)
                {
                    amendedArray[i] = array[i + 1];
                    continue;
                }
                amendedArray[i] = array[i];
            }
            return amendedArray;
        }

        /// <summary>
        /// Inserts a new array element at the start.
        /// </summary>
        /// <param name="array">Input array.</param>
        /// <param name="number">Number to be added.</param>
        /// <returns>A new array with element added at a given index. If an array is empty or null, returns new array with number in it.</returns>
        public static int[] InsertFirst(int[] array, int number)
        {            
            if (IsArrayNullOrEmpty(array))
            {
                int[] newArray = { number };
                return newArray;
            }

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
            if (IsArrayNullOrEmpty(array))
            {
                int[] newArray = { number };
                return newArray;
            }

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
            if (array == null)
            {
                int[] newArray = { number };
                return newArray;
            }

            if (index < 0 || index > array.Length)
            {
                return array;
            }

            var amendedArray = new int[array.Length + 1];

            for (int i = 0; i < amendedArray.Length; i++)
            {
                if (i == index)
                {
                    amendedArray[index] = number;
                    continue;
                }
                if (i > index)
                {
                    amendedArray[i] = array[i - 1];
                    continue;
                }
                amendedArray[i] = array[i];
            }
            return amendedArray;
        }

        public static bool IsArrayNullOrEmpty(int [] array)
        {
            return array == null || array.Length == 0;
        }
    }
}
