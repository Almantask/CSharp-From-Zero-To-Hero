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

            var flag = true;
            var temp = 0;
            var numLength = 0;

            if (array == null)
            {
                return;
            }
            else
            {
                numLength = array.Length;
            }

            //sorting an array  
            for (var i = 1; (i <= (numLength - 1)) && flag; i++)
            {
                flag = false;
                for (var j = 0; j < (numLength - 1); j++)
                {
                    if (array[j + 1] < array[j])
                    {
                        temp = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = temp;
                        flag = true;
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
            var stop = 0;

            if (array == null)
            {
                return;
            }
            else
            {
                stop = array.Length / 2;
            }


            for (var i = 0; i < stop; i++)
            {
                var temp = array[i];
                array[i] = array[array.Length - i - 1];
                array[array.Length - i - 1] = temp;
            }
        }

        /// <summary>
        /// Remove last element in array.
        /// </summary>
        /// <param name="array">Input array.</param>
        /// <returns>A new array with the last element removed. If an array is empty or null, returns input array.</returns>
        public static int[] RemoveLast(int[] array)
        {
            var newArray = ProcessArray(array, array.Length - 1); 
            return newArray;
        }

        /// <summary>
        /// Remove first element in array.
        /// </summary>
        /// <returns>A new array with the first element removed. If an array is empty or null, returns input array.</returns>
        public static int[] RemoveFirst(int[] array)
        {
            var newArray = ProcessArray(array, 0);
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
            var newArray = ProcessArray(array, index);
            return newArray; 
        }

        private static int[] ProcessArray(int[] array, int index)
        {
            var newArray = CheckForInValidCases(array, index);
            newArray = Remove(newArray, index);
            return newArray;
        }

        private static int[] CheckForInValidCases(int[] array, int index)
        {
            if (array == null || index < 0 || index == array.Length || array.Length == 0)
            {
                return array;
            }

            var newArray = ProcessArray(array, index);
            return newArray; 
        }

        private static int[] Remove(int[] array, int index)
        {
            var lengthOldArray = array.Length;
            var newArray = new int[lengthOldArray - 1];

            for (int i = 0; i <= array.Length - 1 ; i++)
            {
                if(i < index)
                {
                    // copy the orginal content
                    newArray[i] = array[i]; 
                } else if (i > index)  
                {
                    //  because the index is now 1 to high for the new index , we copy it to a index 1 lower
                    newArray[i - 1 ] = array[i] ; 
                }
            }

            return newArray; 
        }

        /// <summary>
        /// Inserts a new array element at the start.
        /// </summary>
        /// <param name="array">Input array.</param>
        /// <param name="number">Number to be added.</param>
        /// <returns>A new array with element added at a given index. If an array is empty or null, returns input array.</returns>
        public static int[] InsertFirst(int[] array, int number)
        {
            // ToDo: implement.
            return array;
        }

        /// <summary>
        /// Inserts a new array element at the end.
        /// </summary>
        /// <param name="array">Input array.</param>
        /// <param name="number">Number to be added.</param>
        /// <returns>A new array with element added in the end of array. If an array is empty or null, returns input array.</returns>
        public static int[] InsertLast(int[] array, int number)
        {
            // ToDo: implement.
            return array;
        }

        /// <summary>
        /// Inserts a new array element at the specified index.
        /// </summary>
        /// <param name="array">Input array.</param>
        /// <param name="number">Number to be added.</param>
        /// <param name="index">Index at which array element should be added.</param>
        /// <returns>A new array with element inserted at a given index. If an array is empty or null, returns input array.</returns>
        public static int[] InsertAt(int[] array, int number, int index)
        {
            // ToDo: implement.
            return array;
        }
    }
}
