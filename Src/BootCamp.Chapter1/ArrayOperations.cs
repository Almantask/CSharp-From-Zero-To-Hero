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
            if (ArrayIsNullOrEmpty(array))
            {
                return;
            }

            //Bubble Sort (Ascending)
            for (var i = 0; i <= array.Length - 2; i++)
            {
                for (var j = 0; j <= array.Length - 2; j++)
                {
                    if (array[j] > array[j + 1])
                    {
                        var temp = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = temp;
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
            if(ArrayIsNullOrEmpty(array))
            {
                return;
            }

            var temp = 0;
            for (var i = 0; i < array.Length; i++)
            {
                if (i == array.Length / 2)
                {
                    break;
                }
                temp = array[i];
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
            if(ArrayIsNullOrEmpty(array))
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
            if(ArrayIsNullOrEmpty(array))
            {
                return array;
            }
            
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
            if (ArrayIsNullOrEmpty(array))
            {
                return array;
            }

            if (index < 0 || index > array.Length - 1)
            {
                return array;
            }

            var newArray = new int[array.Length - 1];
            var j = 0;
            for (var i = 0; i < array.Length; i++)
            {
                if (i != index)
                {
                    newArray[j++] = array[i];
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
            if(ArrayIsNullOrEmpty(array))
            {
                return new [] { number };
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
            if(ArrayIsNullOrEmpty(array))
            {
                return new [] { number };
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
            //For handling when array is null.
            //If array is null then return number in array.
            if (array == null)
            {
                return new [] { number };
            }

            //For handling when array is empty.
            //If array is empty then there are two situations in test cases.
            //One situation happens if also index is 0 then return number in array.
            //Another situation happens if index is other than 0 then return empty array.
            if (array.Length == 0)
            {
                if (index == 0)
                {
                    return new[] { number };
                }
                return new int[0];
            }

            var newArray = new int[array.Length + 1];
            var j = 0;
            for (var i = 0; i < newArray.Length; i++)
            {
                newArray[i] = (i == index) ? number : array[j++];
            }

            return newArray;
        }

        private static bool ArrayIsNullOrEmpty(int[] array)
        {
            if (array == null || array.Length == 0)
            {
                return true;
            }
            return false;
        }

    }
}
