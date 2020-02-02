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

            if (CheckForNullORZeroLength(array))
            {
                return;
            }

            int[] newArray = new int[array.Length];

            // this loop goes through the whole array checking each number in array for which POSITION it should be in the newArray (i > k = +1).
            // then it checks if the number (IsSameNumberCheck) is already in the newArray (multiple times) and places it after those.
            for (int i = 0; i < array.Length; i++)
            {
                int position = 0;
                for (int k = 0; k < array.Length; k++)
                {
                    if (array[i] > array[k])
                    {
                        position++;
                    }
                }
                bool isSameNumberCheck = true;

                while (isSameNumberCheck)
                {
                    if (array[i] == 0)
                    {
                        isSameNumberCheck = false;
                    }
                    else if (array[i] == newArray[position])
                    {
                        position++;
                    }
                    else
                    {
                        isSameNumberCheck = false;
                    }
                }

                newArray[position] = array[i];

            }
            for (int i = 0; i < newArray.Length; i++)
            {
                array[i] = newArray[i];
            }

        }

        private static bool CheckForNullORZeroLength(int[] array)
        {
            if (array == null || array.Length == 0)
            {
                return true;
            }
            return false;
        }

        /// <summary>
        /// Reverse the array elements, first being last and so on.
        /// If array empty or null- don't do anything.
        /// </summary>
        /// <param name="array">Input array in a random order.</param>
        public static void Reverse(int[] array)
        {
            if (CheckForNullORZeroLength(array))
            {
                return;
            }

            for (int i = 0; i < array.Length / 2; i++)
            {
                int temp = array[i];
                array[i] = array[array.Length - 1 - i];
                array[array.Length - 1 - i] = temp;
            }
        }

        /// <summary>
        /// Remove last element in array.
        /// </summary>
        /// <param name="array">Input array.</param>
        /// <returns>A new array with the last element removed. If an array is empty or null, returns input array.</returns>
        public static int[] RemoveLast(int[] array)
        {
            if (CheckForNullORZeroLength(array))
            {
                return array;
            }

            int[] newArray = new int[array.Length - 1];

            for (int i = 0; i < array.Length - 1; i++)
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
            if (CheckForNullORZeroLength(array))
            {
                return array;
            }

            int[] newArray = new int[array.Length - 1];

            for (int i = 0; i < array.Length - 1; i++)
            {
                newArray[i] = array[i + 1];
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
            if (array == null || array.Length == 0 || index < 0 || index > array.Length - 1)
            {
                return array;
            }

            int[] newArray = new int[array.Length - 1];
            bool isAfterIndex = false;

            for (int i = 0; i < array.Length - 1; i++)
            {
                if (i == index)
                {
                    isAfterIndex = true;
                }

                if (!isAfterIndex)
                {
                    newArray[i] = array[i];
                }
                else
                {
                    newArray[i] = array[i + 1];
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
            if (array == null)
            {
                return new int[] { number };
            }

            int[] newArray = new int[array.Length + 1];

            newArray[0] = number;

            for (int i = 0; i < array.Length; i++)
            {
                newArray[i + 1] = array[i];
            }

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
            if (array == null)
            {
                return new int[] { number };
            }

            int[] newArray = new int[array.Length + 1];

            newArray[array.Length] = number;

            for (int i = 0; i < array.Length; i++)
            {
                newArray[i] = array[i];
            }

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
            if (array == null)
            {
                if (index == 0)
                {
                    return new int[] { number };
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
                
            if (array.Length == 0)
            {
                return new int[] { number };
            }

            int[] newArray = new int[array.Length + 1];

            newArray[index] = number;

            bool isAfterIndex = false;

            for (int i = 0; i < array.Length; i++)
            {
                if (i == index)
                {
                    isAfterIndex = true;
                }

                if (!isAfterIndex)
                {
                    newArray[i] = array[i];
                }
                else
                {
                    newArray[i + 1] = array[i];
                }
            }

            return newArray;
        }
    }
}
