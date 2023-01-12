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
            if ((array?.Length > 0) == false)
                return;

            bool didArrayGetSorted;
            do
            {
                didArrayGetSorted = false;
                for (int i = 0; i <= array.Length - 2; i++)
                {
                    if (array[i] > array[i + 1])
                    {
                        didArrayGetSorted = true;
                        int tempVal = array[i];
                        array[i] = array[i + 1];
                        array[i + 1] = tempVal;
                    }
                }
            } while (didArrayGetSorted);
        }

        /// <summary>
        /// Reverse the array elements, first being last and so on.
        /// If array empty or null- don't do anything.
        /// </summary>
        /// <param name="array">Input array in a random order.</param>
        public static void Reverse(int[] array)
        {
            if ((array?.Length > 0) == false)
                return;

            var originalArray = new int[array.Length];
            for (int i = 0; i < originalArray.Length; i++)
            {
                originalArray[i] = array[i];
            }

            for (int i = array.Length - 1, j = 0; i >= 0; i--, j++)
            {
                array[j] = originalArray[i];
            }
        }

        /// <summary>
        /// Remove last element in array.
        /// </summary>
        /// <param name="array">Input array.</param>
        /// <returns>A new array with the last element removed. If an array is empty or null, returns input array.</returns>
        public static int[] RemoveLast(int[] array)
        {
            if ((array?.Length > 0) == false)
            {
                return array;
            }

            int[] newArray = RemoveAt(array, array.Length - 1);

            return newArray;
        }

        /// <summary>
        /// Remove first element in array.
        /// </summary>
        /// <returns>A new array with the first element removed. If an array is empty or null, returns input array.</returns>
        public static int[] RemoveFirst(int[] array)
        {
            int[] newArray = RemoveAt(array, 0);

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
            if ((array?.Length > 0) == false)
            {
                return array;
            }

            if (index < 0 || index >= array.Length)
            {
                return array;
            }

            var newArray = new int[array.Length - 1];

            for (int i = 0; i < array.Length; i++)
            {
                if (i != index && i < index)
                {
                    newArray[i] = array[i];
                }
                else if (i > index)
                {
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
        /// <returns>A new array with element added at a given index. If an array is empty or null, returns new array with number in it.</returns>
        public static int[] InsertFirst(int[] array, int number)
        {
            int[] newArray = InsertAt(array, number, 0);

            return newArray;
        }

        /// <summary>
        /// Inserts a new array element at the end.
        /// </summary>
        /// <param name="array">Input array.</param>
        /// <param name="number">Number to be added.</param>
        /// <returns>A new array with element added in the end of array. If an array is empty or null, returns new array with number in it.</returns>
        public static int[] InsertLast(int[] array, int number)
        {
            int lastIndex = array?.Length > 0 ? array.Length : 0;
            int[] newArray = InsertAt(array, number, lastIndex);

            return newArray;
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
            int newLength = array == null ? 1 : array.Length + 1;

            if (index > newLength - 1 || index < 0)
                return array;

            var newArray = new int[newLength];

            for (int i = 0; i < newLength; i++)
            {
                if (i != index && i < index)
                {
                    newArray[i] = array[i];
                }
                else if (i == index)
                {
                    newArray[i] = number;
                }
                else if (i > index)
                {
                    newArray[i] = array[i - 1];
                }
            }

            return newArray;
        }
    }
}
