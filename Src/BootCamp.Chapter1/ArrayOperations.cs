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
            else
            {
                for (int i = 0; i < array.Length -1; i++)
                {
                    for (int j = i + 1; j < array.Length; j++)
                    {
                        if (array[i] > array[j])
                        {
                            Swap(array, i, j);
                        }
                    }
                }
            }
        }

        private static void Swap(int[] array, int i, int j)
        {
            int aux = array[i];
            array[i] = array[j];
            array[j] = aux;
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
            else
            {              

                for (int i = 0; i < array.Length / 2; i++)
                {
                    Swap(array, i, array.Length - i - 1);
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
            if (array == null || array.Length == 0)
            {
                return array;
            }
            else
            {
                var array2 = new int[array.Length-1];
                for (int i = 0; i < array.Length-1; i++)
                {
                    array2[i] = array[i];
                }
                return array2;
            }
        }

        /// <summary>
        /// Remove first element in array.
        /// </summary>
        /// <returns>A new array with the first element removed. If an array is empty or null, returns input array.</returns>
        public static int[] RemoveFirst(int[] array)
        {
            if (array == null || array.Length == 0)
            {
                return array;
            }
            else
            {
                var array2 = new int[array.Length - 1];
                for (int i = 0; i < array2.Length; i++)
                {
                    array2[i] = array[i + 1];
                }
                return array2;
            }
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

            var array2 = new int[array.Length - 1];
            for (int i = 0; i < array2.Length; i++)
            {                
                if (i<index)
                {
                    array2[i] = array[i];
                }
                else
                {
                    array2[i] = array[i + 1];
                }
            }
            return array2;
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
                array = new int[] { number };
                return array;

            }
            else if (array.Length == 0)
            {
                var array2 = new int[array.Length + 1];
                for (int i = 0; i < array2.Length; i++)
                {
                    array2[i] = number;
                }
                return array2;
            }
            else
            {
                var array2 = new int[array.Length + 1];
                array2[0] = number;
                for (int i = 1; i < array2.Length; i++)
                {
                    array2[i] = array[i - 1];
                }
                return array2;
            }
            
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
                array = new int[] { number };
                return array;

            }
            else if (array.Length == 0)
            {
                var array2 = new int[array.Length + 1];
                for (int i = 0; i < array2.Length; i++)
                {
                    array2[i] = number;
                }
                return array2;
            }
            else
            {
                var array2 = new int[array.Length + 1];
                
                for (int i = 0; i < array2.Length - 1; i++)
                {
                    array2[i] = array[i];
                }
                array2[array2.Length - 1] = number;

                return array2;
            }
           
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

            // I know I have a lot of repeated code in this homework, but I'm glad it finnaly works!!!

            if (array == null && index == 0)
            {
                array = new int[] { number };
                return array;

            }
            if (array.Length == 0 && index == 1 || index == -1)
                return array;            

            var array2 = new int[array.Length + 1];
            array2[index] = number;

            for (int i = 0; i < array.Length; i++)
            {
                if (i < index)
                {
                    array2[i] = array[i];
                }
                else
                {
                    array2[i + 1] = array[i];
                }
            }
            return array2;

        }
    }
}
