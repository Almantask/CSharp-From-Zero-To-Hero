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
            if (array == null || array.Length == 0)
            {
                return;
            }

            var arrayLength = array.Length;
            // loop through all elements
            for (var i = 0; i < arrayLength; i++)
            {
                // compare element on current index to all next elements
                for (var j = i + 1; j < arrayLength; j++)
                {
                    // keep swapping till lowest is found
                    if (array[i] > array[j])
                    {
                        var tmp = array[i];
                        array[i] = array[j];
                        array[j] = tmp;
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
            if (array == null || array.Length == 0)
            {
                return;
            }

            var arrayLength = array.Length;
            for (var i = 0; i < arrayLength/2; i++)
            {
                array[i] = array[i] + array[arrayLength - i - 1];
                array[arrayLength - i-1] = array[i] - array[arrayLength - i - 1];
                array[i] = array[i] - array[arrayLength - i - 1];
            }
        }

        /// <summary>
        /// Remove last element in array.
        /// </summary>
        /// <param name="array">Input array.</param>
        /// <returns>A new array with the last element removed. If an array is empty or null, returns input array.</returns>
        public static int[] RemoveLast(int[] array)
        {
            int arrayLength = 0;
            if (array != null && array.Length != 0)
            {
                arrayLength = array.Length-1;
            }

            var resultArray = RemoveElementInArray(array, arrayLength);
            return resultArray;
        }

        /// <summary>
        /// Remove first element in array.
        /// </summary>
        /// <returns>A new array with the first element removed. If an array is empty or null, returns input array.</returns>
        public static int[] RemoveFirst(int[] array)
        {
            var resultArray = RemoveElementInArray(array, 0);
            return resultArray;
        }

        /// <summary>
        /// Removes array element at given index.
        /// </summary>
        /// <param name="array">Input array.</param>
        /// <param name="index">Index at which array element should be removed.</param>
        /// <returns>A new array with element removed at a given index. If an array is empty or null, returns input array.</returns>
        public static int[] RemoveAt(int[] array, int index)
        {
            var resultArray = RemoveElementInArray(array, index);
            return resultArray;
        }

        private static int[] RemoveElementInArray(int[] array, int index)
        {
            if (array == null || array.Length == 0)
            {
                return array;
            }

            var arrayLength = array.Length;
            if (index < 0 || index >= arrayLength)
            {
                return array;
            }

            int[] newArray = new int[arrayLength - 1];
            var removedIndex = 0;
            // make a copy of array by value (not reference) and count/add if index is removed
            for (var i = 0; i < newArray.Length; i++)
            {
                if (i == index)
                {
                    removedIndex = 1;
                }
                newArray[i] = array[i + removedIndex];
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
            var resultArray = InsertElementInArray(array, number, 0);
            return resultArray;
        }

        /// <summary>
        /// Inserts a new array element at the end.
        /// </summary>
        /// <param name="array">Input array.</param>
        /// <param name="number">Number to be added.</param>
        /// <returns>A new array with element added in the end of array. If an array is empty or null, returns new array with number in it.</returns>
        public static int[] InsertLast(int[] array, int number)
        {
            int arrayLength = 0;
            if (array != null && array.Length != 0)
            {
                arrayLength = array.Length;
            }

            var resultArray = InsertElementInArray(array, number, arrayLength);
            return resultArray;
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
            var resultArray = InsertElementInArray(array, number, index);
            return resultArray;
        }

        private static int[] InsertElementInArray(int[] array, int number, int index)
        {
            if (array == null || array.Length == 0)
            {
                if (array != null && array.Length == 0 && index != 0)
                {
                    return array;
                }
                var newArrayNumber = new[] { number };
                return newArrayNumber;
            }

            var arrayLength = array.Length;
            if (index < 0 || index > arrayLength)
            {
                return array;
            }
            
            int[] newArray = new int[arrayLength + 1];
            var addedIndex = 0;
            // make a copy of array by value (not reference) and count/add if index added
            for (var i = 0; i < newArray.Length; i++)
            {
                if (i == index)
                {
                    newArray[i] = number;
                    addedIndex = 1;
                } 
                else
                {
                    newArray[i] = array[i - addedIndex];
                }
            }
            return newArray;
        }
    }
}
