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
            if(array == null|| array.Length == 0)
            {
                return;
            }
            for(int i = 0;i < array.Length; i++)
            {
                for(int j = 1;j < array.Length - i; j++)
                {
                    if (array[i] > array[i+j])
                    {
                        int temp = array[i];
                        array[i] = array[i + j];
                        array[i + j] = temp;
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
            int[] clone =(int[]) array.Clone();
            for(int i = 0;i < array.Length; i++)
            {
                array[i] = clone[array.Length - 1 - i];
            }

        }

        /// <summary>
        /// Remove last element in array.
        /// </summary>
        /// <param name="array">Input array.</param>
        /// <returns>A new array with the last element removed. If an array is empty or null, returns input array.</returns>
        public static int[] RemoveLast(int[] array)
        {
            return RemoveAt(array, array.Length - 1);
        }

        /// <summary>
        /// Remove first element in array.
        /// </summary>
        /// <returns>A new array with the first element removed. If an array is empty or null, returns input array.</returns>
        public static int[] RemoveFirst(int[] array)
        {
            return RemoveAt(array,0);
        }

        /// <summary>
        /// Removes array element at given index.
        /// </summary>
        /// <param name="array">Input array.</param>
        /// <param name="index">Index at which array element should be removed.</param>
        /// <returns>A new array with element removed at a given index. If an array is empty or null, returns input array.</returns>
        public static int[] RemoveAt(int[] array, int index)
        {
            if (array == null || array.Length == 0)
            {
                return array;
            }
            if(index >= array.Length || index < 0)
            {
                System.Console.WriteLine("index is out of range.");
                return array;
            }
            var newArray = new int[array.Length - 1];
            for(int i = 0; i < array.Length - 1; i++)
            {
                if (i < index)
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
            if (array == null || array.Length == 0)
            {
                if(index == 0)
                {
                    array = new int[] { number };
                    return array;

                }
                else
                {
                    return array;
                }
                
            }
            if (index > array.Length || index < 0)
            {
                System.Console.WriteLine("index is out of range.");
                return array;
            }
            var newArray = new int[array.Length + 1];
            newArray[index] = number;
            for(int i = 0; i < array.Length; i++)
            {
                if(i < index)
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
