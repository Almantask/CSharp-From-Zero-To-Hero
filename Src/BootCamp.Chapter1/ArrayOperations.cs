using System.Linq;

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
                array = null;
                return;
            }
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array.Length - 1; j++)
                {
                    if (array[j] < array[j + 1]) continue;
                    else
                    {
                        int temp = array[j];
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
            if (array == null || array.Length == 0)
            {
                array = null;
                return;
            }
            // ToDo: implement.
            for (int i = 0; i * 2 < array.Length - 1; i++)
            {
                int temp = array[i];
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

            if (array == null || array.Length == 0)
            {
                return array;
            }
            int[] tempArray = new int[array.Length - 1];
            for (int i = 0; i < tempArray.Length; i++)
            {
                tempArray[i] = array[i];
            }
            return tempArray;
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
            int[] tempArray = new int[array.Length - 1];
            for (int i = 0; i < tempArray.Length; i++)
            {
                tempArray[i] = array[i + 1];
            }
            return tempArray;
        }

        /// <summary>
        /// Removes array element at given index.
        /// </summary>
        /// <param name="array">Input array.</param>
        /// <param name="index">Index at which array element should be removed.</param>
        /// <returns>A new array with element removed at a given index. If an array is empty or null, returns input array.</returns>
        public static int[] RemoveAt(int[] array, int index)
        {
            
            if (array == null || array.Length == 0 || index > array.Length - 1 || index < 0)
            {
                return array;
            }
            int[] tempArray = new int[array.Length - 1];
            for(int i = 0; i < array.Length; i++)
            {
                for(int j = 0; j < array.Length; j++)
                {
                    if(i == index)
                    {

                    }
                }
            }
            return tempArray;
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
                return new int[] { number };
            }
            int[] tempArray = new int[array.Length + 1];
            for(int i = 0; i < tempArray.Length; i++)
            {
                if(i == 0)
                {
                    tempArray[0] = number;
                    continue;
                }
                tempArray[i] = array[i - 1];
            }
            return tempArray;
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
                return new int[] { number };
            }
            int[] tempArray = new int[array.Length + 1];
            for (int i = 0; i < array.Length; i++)
            {
                tempArray[i] = array[i];
            }
            tempArray[tempArray.Length - 1] = number;
            return tempArray;
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
                return new int[] { number };
            }
            if(index > array.Length || index < array.Length)
            {
                return array;
            }
            int[] tempArray = new int[array.Length + 1];


            for(int i = 0; i < array.Length; i++)
            {
                if(index == i)
                {
                    continue;
                }
                if(i > index)
                {
                    tempArray[i] = array[i - 1];
                    break;
                }
                tempArray[i] = array[i];
            }
            tempArray[index] = number;
            return tempArray;
        }
    }
}
