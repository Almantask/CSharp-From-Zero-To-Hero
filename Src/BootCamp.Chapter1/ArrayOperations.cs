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
            if (array == null || array.Length == 0) return;

            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 1; j < array.Length; j++)
                {
                    if (array[j - 1] > array[j])
                    {
                        int buffer = array[j];
                        array[j] = array[j - 1];
                        array[j - 1] = buffer;
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
            if (array == null || array.Length == 0) return;

            for (int i = (array.Length - 1); i >= 0; i--)
            {
                for (int j = (array.Length - 1); j >= 0; j--)
                {
                    if (array[i] < array[j])
                    {
                        int buffer = array[i];
                        array[i] = array[j];
                        array[j] = buffer;
                    }
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
            if (array == null || array.Length == 0) return array;

            int[] removedLastElement = new int[array.Length - 1];
            for (int i = 0; i < removedLastElement.Length; i++)
            {
                removedLastElement[i] = array[i];
            }
            return removedLastElement;
        }

        /// <summary>
        /// Remove first element in array.
        /// </summary>
        /// <returns>A new array with the first element removed. If an array is empty or null, returns input array.</returns>
        public static int[] RemoveFirst(int[] array)
        {
            if (array == null || array.Length == 0) return array;

            int[] removedFirstElement = new int[array.Length - 1];
            for (int i = 0; i < removedFirstElement.Length; i++)
            {
                removedFirstElement[i] = array[i + 1];
            }
            return removedFirstElement;
        }

        /// <summary>
        /// Removes array element at given index.
        /// </summary>
        /// <param name="array">Input array.</param>
        /// <param name="index">Index at which array element should be removed.</param>
        /// <returns>A new array with element removed at a given index. If an array is empty or null, returns input array.</returns>
        public static int[] RemoveAt(int[] array, int index)
        {
            if (array == null || array.Length == 0) return array;

            int[] removedIndex = new int[array.Length - 1];
            for (int i = 0; i < removedIndex.Length; i++)
            {
                if (index <= i)
                    removedIndex[i] = array[i + 1];
                else
                    removedIndex[i] = array[i];
            }
            return removedIndex;
        }

        /// <summary>
        /// Inserts a new array element at the start.
        /// </summary>
        /// <param name="array">Input array.</param>
        /// <param name="number">Number to be added.</param>
        /// <returns>A new array with element added at a given index. If an array is empty or null, returns new array with number in it.</returns>
        public static int[] InsertFirst(int[] array, int number)
        {
            if (array == null || array.Length == 0)
            {
                int[] emptyArray = new int[] { number };
                return emptyArray;
            }

            int[] insertedFirstElement = new int[array.Length + 1];
            for (int i = 0; i < insertedFirstElement.Length; i++)
            {
                if (i == 0)
                    insertedFirstElement[i] = number;
                else
                    insertedFirstElement[i] = array[i - 1];
            }
            return insertedFirstElement;
        }

        /// <summary>
        /// Inserts a new array element at the end.
        /// </summary>
        /// <param name="array">Input array.</param>
        /// <param name="number">Number to be added.</param>
        /// <returns>A new array with element added in the end of array. If an array is empty or null, returns new array with number in it.</returns>
        public static int[] InsertLast(int[] array, int number)
        {
            if (array == null || array.Length == 0)
            {
                int[] emptyArray = new int[] { number };
                return emptyArray;
            }

            int[] insertedLastElement = new int[array.Length + 1];
            for (int i = 0; i < insertedLastElement.Length; i++)
            {
                if (i == (insertedLastElement.Length - 1))
                    insertedLastElement[i] = number;
                else
                    insertedLastElement[i] = array[i];
            }
            return insertedLastElement;
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
            if (array == null || array.Length == 0)
            {
                int[] emptyArray = new int[] { number };
                return emptyArray;
            }

            int[] insertedElementAtIndex = new int[array.Length + 1];
            for (int i = 0; i < insertedElementAtIndex.Length; i++)
            {
                if (index == i)
                    insertedElementAtIndex[i] = number;
                else if (index < i)
                    insertedElementAtIndex[i] = array[i - 1];
                else
                    insertedElementAtIndex[i] = array[i];
            }
            return insertedElementAtIndex;
        }
    }
}
