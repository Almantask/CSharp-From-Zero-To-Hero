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
            if (IsNullOrEmpty(array)) return;

            bool isSorted;
            do
            {
                isSorted = true;
                for (int i = 0; i < array.Length - 1; i++)
                {
                    if (array[i] > array[i + 1])
                    {
                        int oldIndexValue = array[i + 1];
                        int newIndexValue = array[i];

                        array[i] = oldIndexValue;
                        array[i + 1] = newIndexValue;
                        isSorted = false;
                    }
                }
            } while (!isSorted);
        }

        /// <summary>
        /// Reverse the array elements, first being last and so on.
        /// If array empty or null- don't do anything.
        /// </summary>
        /// <param name="array">Input array in a random order.</param>
        public static void Reverse(int[] array)
        {
            if (IsNullOrEmpty(array)) return;

            var tempArray = CloneArray(array);
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = tempArray[^(i + 1)];
            }
        }

        // Clone an array
        private static int[] CloneArray(int[] baseArray)
        {
            var newArray = new int[baseArray.Length];

            int i = 0;
            foreach (var values in baseArray)
            {
                newArray[i] = values;
                i++;
            }

            return newArray;
        }

        /// <summary>
        /// Remove last element in array.
        /// </summary>
        /// <param name="array">Input array.</param>
        /// <returns>A new array with the last element removed. If an array is empty or null, returns input array.</returns>
        public static int[] RemoveLast(int[] array)
        {
            if (IsNullOrEmpty(array)) return array;

            return RemoveElement(array, array.Length);
        }

        /// <summary>
        /// Remove first element in array.
        /// </summary>
        /// <returns>A new array with the first element removed. If an array is empty or null, returns input array.</returns>
        public static int[] RemoveFirst(int[] array)
        {
            if (IsNullOrEmpty(array)) return array;

            return RemoveElement(array, 0);
        }

        /// <summary>
        /// Removes array element at given index.
        /// </summary>
        /// <param name="array">Input array.</param>
        /// <param name="index">Index at which array element should be removed.</param>
        /// <returns>A new array with element removed at a given index. If an array is empty or null, returns input array.</returns>
        public static int[] RemoveAt(int[] array, int index)
        {
            if (IsNullOrEmpty(array) || !IsIndexInRange(array, index)) return array;

            return RemoveElement(array, index);
        }

        // Return an array without the value in a specific index.
        private static int[] RemoveElement(int[] array, int index)
        {
            int[] newArray = new int[array.Length - 1];

            for (int i = 0; i < newArray.Length; i++)
            {
                if (i >= index)
                {
                    newArray[i] = array[i + 1];
                }
                else
                {
                    newArray[i] = array[i];
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
            if (IsNullOrEmpty(array))
            {
                return new[] { number };
            }

            return InsertElement(array, number, 0);
        }

        /// <summary>
        /// Inserts a new array element at the end.
        /// </summary>
        /// <param name="array">Input array.</param>
        /// <param name="number">Number to be added.</param>
        /// <returns>A new array with element added in the end of array. If an array is empty or null, returns new array with number in it.</returns>
        public static int[] InsertLast(int[] array, int number)
        {
            if (IsNullOrEmpty(array))
            {
                return new[] { number };
            }

            return InsertElement(array, number, array.Length);
        }

        /// <summary>
        /// Inserts a new array element at a specified index.
        /// </summary>
        /// <param name="array">Input array.</param>
        /// <param name="number">Number to be added.</param>
        /// <param name="index">Index at which array element should be added.</param>
        /// <returns>A new array with element inserted at a given index. If an array is empty or null, returns new array with number in it.</returns>
        public static int[] InsertAt(int[] array, int number, int index)
        {
            if (array == null)
            {
                return new[] { number };
            }
            else if (array.Length == 0 && IsIndexInRange(array, index))
            {
                return new[] { number };
            }
            else if (array.Length == 0 && !IsIndexInRange(array, index))
            {
                return array;
            }

            return InsertElement(array, number, index);
        }

        // Return an array with a new value in a specific index, all others value are moved by 1 index forward.
        private static int[] InsertElement(int[] array, int element, int index)
        {
            int[] newArray = new int[array.Length + 1];

            for (int i = 0; i < newArray.Length; i++)
            {
                if (i > index)
                {
                    newArray[i] = array[i - 1];
                }
                else if (i == index)
                {
                    newArray[i] = element;
                }
                else
                {
                    newArray[i] = array[i];
                }
            }

            return newArray;
        }

        // Check if index parsed is in a valid range.
        private static bool IsIndexInRange(int[] array, int index)
        {
            return (array.Length == 0 && index == 0) || (index >= 0 && index <= (array.Length - 1));
        }

        // Check if arrays is Null or Empty.
        private static bool IsNullOrEmpty(int[] array)
        {
            return array == null || array.Length == 0;
        }
    }
}
