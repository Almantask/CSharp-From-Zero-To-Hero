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
            if (array == null || array.Length < 1) { return; }
            // Selection sort.
            int tempElement;
            int indexForMinElement;
            for (int i = 0; i < array.Length - 1; i++)
            {
                indexForMinElement = i;
                for (int j = i + 1; j < array.Length; j++)
                {
                    // Check for a smaller element than previosly found.
                    if (array[j] < array[indexForMinElement])
                    {
                        indexForMinElement = j;
                    }
                }
                // If we found smaller element, switch.
                if (indexForMinElement != i)
                {
                    tempElement = array[i];
                    array[i] = array[indexForMinElement];
                    array[indexForMinElement] = tempElement;
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
            if (array == null || array.Length < 1) { return; }
            int tempElement;
            for (int i = 0; i < array.Length/2; i++)
            {
                if(((array.Length - i) - i) > 1)
                {
                    tempElement = array[i];
                    array[i] = array[(array.Length - 1) - i];
                    array[(array.Length - 1) - i] = tempElement;
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
            if (array == null) { return array; }
            else { return RemoveAt(array, array.Length - 1); }
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
            if (array == null || array.Length < 1) { return array; }
            var newArray = new int[array.Length - 1];
            // If index is out of range for array return input array.
            if(index < 0 || index > array.Length - 1) { return array; }
            int newArrayIndex = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if(index == i) { continue; }
                newArray[newArrayIndex] = array[i];
                newArrayIndex++;
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
            if (array == null) { return InsertAt(array, number, 0); }
            else { return InsertAt(array, number, array.Length); }
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
            if ((array == null || array.Length < 1) && index == 0) { return new int[1] { number }; }
            var newArray = new int[array.Length + 1];
            // If index is out of range for array return input array.
            if (index < 0 || index > array.Length) { return array; }
            int newArrayIndex = 0;
            for (int i = 0; i < newArray.Length; i++)
            {
                if (index == i)
                {
                    newArray[i] = number;
                    newArrayIndex++;
                }
                if(i < array.Length)
                {
                    newArray[newArrayIndex] = array[i];
                    newArrayIndex++;
                }
            }
            return newArray;
        }
    }
}
