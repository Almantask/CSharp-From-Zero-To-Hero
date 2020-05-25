
namespace BootCamp.Chapter1
{
    public static class ArrayOperations
    {
        /// <summary>
        /// Sort the array in ascending order.
        /// If array empty or null- don't do anything.
        /// </summary>
        /// <param name="array">Input array in a random order.</param>
        public static int[] Sort(int[] array)
        {
            if (IsArrayNullOrEmpty(array))
                return array;

            int temp;
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array.Length; j++)
                {
                    if (j != array.Length - 1)
                    {
                        if (array[j] > array[j + 1])
                        {
                            temp = array[j];
                            array[j] = array[j + 1];
                            array[j + 1] = temp;
                        }
                    }
                }
            }
            return array;
        }

        /// <summary>
        /// Reverse the array elements, first being last and so on.
        /// If array empty or null- don't do anything.
        /// </summary>
        /// <param name="array">Input array in a random order.</param>
        public static int[] Reverse(int[] array)
        {
            if (IsArrayNullOrEmpty(array))
                return array;

            var reversedArray = new int[array.Length];
            int j = 0;
            for (int i = array.Length; i-- > 0;)
            {
                reversedArray[j] = array[i];
                j++;
            }

            // return the original array --> reversed
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = reversedArray[i];
            }
            return array;
        }

        /// <summary>
        /// Remove last element in array.
        /// </summary>
        /// <param name="array">Input array.</param>
        /// <returns>A new array with the last element removed. If an array is empty or null, returns input array.</returns>
        public static int[] RemoveLast(int[] array)
        {
            if (IsArrayNullOrEmpty(array))
                return array;

            var newArray = new int[array.Length - 1];
            for (int i = 0; i < array.Length -1; i++)
            {
                newArray[i] = array[i];
            }

            return newArray;

        }

        /// <summary>
        /// Remove first element in array.
        /// </summary>
        /// <returns>A new array with the first element removed. If an array is empty or null, returns input array.</returns>
        public static int[] RemoveFirst(int[] array)
        {
            if (IsArrayNullOrEmpty(array))
                return array;

            int j = 0;
            var newArray = new int[array.Length - 1];
            for (int i = 1; i < array.Length; i++, j++)
            {
                newArray[j] = array[i];
            }

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
            if (array == null)
                return null;

            if (index < 0)
                return array;
            if (index > array.Length - 1)
                return array;
            int[] newIntArray = new int[array.Length - 1];
            for (int i = 0, j = 0; i < newIntArray.Length; i++, j++)
            {
                if (i == index)
                {
                    j++;
                }
                newIntArray[i] = array[j];
            }
            return newIntArray;
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
                array = new int[0];

            int[] newIntArray = new int[array.Length + 1];
            newIntArray[0] = number;
            for (int i = 1, j = 0; i < newIntArray.Length; i++, j++)
            {
                newIntArray[i] = array[j];
            }
            return newIntArray;

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
                array = new int[0];

            int[] newIntArray = new int[array.Length + 1];
            for (int i = 0, j = 0; i < array.Length; i++, j++)
            {
                newIntArray[i] = array[j];
            }
            newIntArray[newIntArray.Length - 1] = number;
            return newIntArray;
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
            if (IsArrayNullOrEmpty(array))
                array = new int[0];

            if (array.Length == 0 && index > 0)
            {
                return new int[0];
            }
            if (index <= array.Length + 1 && index >= 0)
            {
                int[] newArray = new int[array.Length + 1];
                for (int i = 0; i < newArray.Length; i++)
                {
                    if (i < index)
                        newArray[i] = array[i];
                    else if (i == index)
                        newArray[i] = number;
                    else
                        newArray[i] = array[i - 1];
                }
                return newArray;
            }
            else
            {
                return new int[0];
            }
        }

        private static bool IsArrayNullOrEmpty(int[] array)
        {
            return (array == null || array.Length == 0);
        }
    }
}
