namespace BootCamp.Chapter
{
    public static class ArrayOps
    {
        public static int FindMaxValue(int[] inputArray)
        {
            if (IsNullOrEmpty(inputArray))
            {
                return default;
            }
            int max = inputArray[0];
            for (int i = 0; i < inputArray.Length; i++)
            {
                if (inputArray[i] > max)
                {
                    max = inputArray[i];
                }
            }
            return max;
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
                return NullArrayHelper(number);
            }
            if (index > array.Length || index < 0)
            {
                return array;
            }

            var tempArray = new int[array.Length + 1];
            tempArray[index] = number;

            for (int i = 0; i < array.Length; i++)
            {
                if (i < index)
                {
                    tempArray[i] = array[i];
                }
                else
                {
                    tempArray[i + 1] = array[i];
                }
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
            return array == null ? NullArrayHelper(number) : InsertAt(array, number, array.Length);
        }

        public static bool IsNullOrEmpty(int[] array)
        {
            return array == null || array.Length == 0;
        }

        /// <summary>
        /// Prints the elements of an int array to the console and displays a message with it.
        /// </summary>
        /// <param name="array">Array to be printed.</param>
        /// <param name="message">Message to be displayed.</param>
        public static void PrintIntArray(int[] array, string message)
        {
            if (!IsNullOrEmpty(array))
            {
                System.Console.WriteLine("Input array is not valid!");
                return;
            }
            System.Console.WriteLine(message);
            foreach (var item in array)
            {
                System.Console.Write(item + "\t");
            }
            System.Console.WriteLine();
        }

        /// <summary>
        /// Removes array element at given index.
        /// </summary>
        /// <param name="array">Input array.</param>
        /// <param name="index">Index at which array element should be removed.</param>
        /// <returns>A new array with element removed at a given index. If an array is empty or null, returns input array.</returns>

        private static int[] NullArrayHelper(int number)
        {
            var nullableArray = new int[1];
            nullableArray[0] = number;
            return nullableArray;
        }
    }
}