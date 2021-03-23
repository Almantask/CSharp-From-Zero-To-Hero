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

            for (var i=0; i<array.Length-1;i++)
            {
                if (array[i]>array[i+1])
                {
                    int x = array[i];
                    array[i] = array[i + 1];
                    array[i + 1] = x;
                    i = -1;
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
            for(var i=0;i<array.Length-1;i++)
            {
                if (array[i]<array[i+1])
                {
                    int x = array[i + 1];
                    array[i + 1] = array[i];
                    array[i] = x;
                    i = -1;
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
            if(!(array==null || array.Length==0))
            {
                int[] newArray = new int[array.Length - 1];
                int i = 0;
                do
                {
                    newArray[i] = array[i];
                    i++;
                }
                while (i < array.Length-1);

                return newArray;
            }
            return array;
        }

        /// <summary>
        /// Remove first element in array.
        /// </summary>
        /// <returns>A new array with the first element removed. If an array is empty or null, returns input array.</returns>
        public static int[] RemoveFirst(int[] array)
        {
            if (!(array==null || array.Length==0))
            {
                int[] newArray = new int[array.Length - 1];
                for(var i=1; i<array.Length;i++)
                {
                    newArray[i - 1] = array[i];
                }

                return newArray;
            }
            return array;
        }

        /// <summary>
        /// Removes array element at given index.
        /// </summary>
        /// <param name="array">Input array.</param>
        /// <param name="index">Index at which array element should be removed.</param>
        /// <returns>A new array with element removed at a given index. If an array is empty or null, returns input array.</returns>
        public static int[] RemoveAt(int[] array, int index)
        {
            if (!(array==null || array.Length==0) && index < array.Length)
            {
                int[] newArray = new int[array.Length-1];

                int j = 0;
                for (var i=0;i<newArray.Length;i++)
                {
                    if(i==index)
                    {
                        j++;
                    }
                    newArray[i] = array[j];
                    j++;
                }

                return newArray;
            }
            return array;
        }

        /// <summary>
        /// Inserts a new array element at the start.
        /// </summary>
        /// <param name="array">Input array.</param>
        /// <param name="number">Number to be added.</param>
        /// <returns>A new array with element added at a given index. If an array is empty or null, returns new array with number in it.</returns>
        public static int[] InsertFirst(int[] array, int number)
        {
            int[] newArray;
            if(!(array==null || array.Length==0))
            {
                newArray = new int[array.Length + 1];
                int i = 0;
                newArray[i] = number;
                foreach(var items in array)
                {
                    i++;
                    newArray[i] = items;
                }
            }
            else
            {
                newArray = new int[] { number };
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

            int[] newArray;
            if (!(array == null || array.Length == 0))
            {
                newArray = new int[array.Length + 1];
                int i = 0;
                foreach(var item in array)
                {
                    newArray[i] = item;
                    i++;
                }

                newArray[i] = number;
            }
            else
            {
                newArray = new int[] { number };
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
            int[] newArray;

            if (!(array == null || array.Length == 0))
            {
                newArray = new int[array.Length + 1];
                int i = 0;
                foreach(var item in array)
                {
                    if (i == index)
                    {
                        newArray[i] = number;
                        i++;
                    }
                    newArray[i] = item;
                    i++;
                    

                }

            }
            else
            {
                newArray = new int[] { number };
            }

            return newArray;
        }
    }
}
