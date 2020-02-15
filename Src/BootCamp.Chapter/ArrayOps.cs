namespace BootCamp.Chapter
{
    public static class ArrayOps
    {
        /// <summary>
        /// Sort the array in ascending order.
        /// If array empty or null- don't do anything.
        /// </summary>
        /// <param name="array">Input array in a random order.</param>
        ///
        public static void Sort(int[] array)
        {
            if (IsNullOrEmpty(array))
            {
                return;
            }

            for (var i = 0; i < array.Length; i++)
            {
                for (var j = i; j > 0 && array[j] < array[j - 1]; j--)
                {
                    SwapElements(array, j, j - 1);
                }
            }
        }

        private static void SwapElements(int[] array, int i, int j)
        {
            int temp = array[i];
            array[i] = array[j];
            array[j] = temp;
        }

        /// <summary>
        /// Reverse the array elements, first being last and so on.
        /// If array empty or null- don't do anything.
        /// </summary>
        /// <param name="array">Input array in a random order.</param>
        public static void Reverse(int[] array)
        {
            if (array == null || array.Length == 0)
            {
                return;
            }

            for (int i = 0; i < array.Length / 2; i++)
            {
                SwapElements(array, i, array.Length - i - 1);
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
            if (array.Length != 0)
            {
                return RemoveAt(array, array.Length - 1);
            }

            return array;
        }

        /// <summary>
        /// Remove first element in array.
        /// </summary>
        /// <returns>A new array with the first element removed. If an array is empty or null, returns input array.</returns>
        public static int[] RemoveFirst(int[] array)
        {
            return array == null || array.Length == 0 ? array : RemoveAt(array, 0);
        }

        /// <summary>
        /// Removes array element at given index.
        /// </summary>
        /// <param name="array">Input array.</param>
        /// <param name="index">Index at which array element should be removed.</param>
        /// <returns>A new array with element removed at a given index. If an array is empty or null, returns input array.</returns>
        public static int[] RemoveAt(int[] array, int index)
        {
            bool ArgumentsAreNotValid = array == null || index < 0 || index >= array.Length;

            if (ArgumentsAreNotValid)
            {
                return array;
            }

            var tempArray = new int[array.Length - 1];
            for (int i = 0; i < tempArray.Length; i++)
            {
                tempArray[i] = i < index ? array[i] : array[i + 1];
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
            return array == null ? NullArrayHelper(number) : InsertAt(array, number, array.Length);
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

        public static int FindIndexOfMaxValue(int[] inputArray)
        {
            if (IsNullOrEmpty(inputArray))
            {
                return default;
            }
            var maxValue = inputArray[0];
            int index = 0;
            for (int i = 0; i < inputArray.Length; i++)
            {
                if (inputArray[i] > maxValue)
                {
                    maxValue = inputArray[i];
                    index = i;
                }
            }
            return index;
        }

        /// <summary>
        /// Transfers the contents of two one dimension arrays to one bi-dimensional array.
        /// </summary>
        /// <param name="array1">First int one dimension input array.</param>
        /// <param name="array2">Second int one dimension input array.</param>
        /// <returns>A new Bi-dimensional int array created from array1 and array2.</returns>
        public static int[][] Construct2dArray(int[] array1, int[] array2)
        {
            if (IsNullOrEmpty(array1) || IsNullOrEmpty(array2))
            {
                System.Console.WriteLine("Input arrays are not valid!");
                return default;
            }

            int[][] newBiDiArr = new int[2][] { array1, array2 };
            for (int i = 0; i < array1.Length; i++)
            {
                newBiDiArr[0][i] = array1[i];
            }
            for (int i = 0; i < array2.Length; i++)
            {
                newBiDiArr[1][i] = array2[i];
            }

            return newBiDiArr;
        }

        /// <summary>
        /// Transfers the elements from one of the arrays in the bi-dimensional array to one dimension array.
        /// </summary>
        /// <param name="inputArray">The array from witch the transfer</param>
        /// <param name="arrayNumber"></param>
        /// <returns>One dimension array based on argument 0 or 1</returns>
        public static int[] Deconstruct2dArray(int[][] inputArray, int arrayNumber)
        {
            bool argumentsAreNotValid = (inputArray == null || inputArray.Length == 0) && (arrayNumber < 0 || arrayNumber > 1);
            if (argumentsAreNotValid)
            {
                System.Console.WriteLine("Arguments are not valid!");
                return default;
            }

            var newArray = new int[inputArray[arrayNumber].Length];
            for (int i = 0; i < newArray.Length; i++)
            {
                newArray[i] = inputArray[arrayNumber][i];
            }
            return newArray;
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

        private static bool IsNullOrEmpty(int[] array)
        {
            return array == null || array.Length == 0;
        }

        private static int[] NullArrayHelper(int number)
        {
            var nullableArray = new int[1];
            nullableArray[0] = number;
            return nullableArray;
        }
    }
}