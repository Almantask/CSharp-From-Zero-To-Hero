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
            // ToDo: implement.
            Sort(array);
        }

        /// <summary>
        /// Reverse the array elements, first being last and so on.
        /// If array empty or null- don't do anything.
        /// </summary>
        /// <param name="array">Input array in a random order.</param>
        public static void Reverse(int[] array)
        {
            if (array != null || array.Length != 0)
            {
                // ToDo: implement.
                int[] tempArr = new int[array.Length];
                int j = 0;

                // create reversed array
                for (int i = array.Length - 1; i >= 0; i--)
                {
                    tempArr[i] = array[j];
                    j++;
                }

                // update reference array
                for (int i = 0; i < array.Length; i++)
                {
                    array[i] = tempArr[i];
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
            // ToDo: implement.
            int[] tempArr = new int[array.Length - 1];

            if (array != null || array.Length != 0)
            {
                for (int i = 0; i < array.Length - 1; i++)
                {
                    tempArr[i] = array[i];
                }

                return tempArr;
            }
            else
            {
                return array;
            }


        }

        /// <summary>
        /// Remove first element in array.
        /// </summary>
        /// <returns>A new array with the first element removed. If an array is empty or null, returns input array.</returns>
        public static int[] RemoveFirst(int[] array)
        {
            int[] tempArr = new int[array.Length - 1];
            // ToDo: implement.
            if (array != null || array.Length != 0)
            {
                
                int j = 0;
                for (int i = 0; i < array.Length - 1; i++)
                {
                    if (j < array.Length - 1)
                    {
                        tempArr[i] = array[i + 1];
                    }
                    else
                    {
                        tempArr[i] = array[i];
                    }

                    j++;
                }

                return tempArr;
            }
            else
            {
                return array;
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
            // ToDo: implement.
            int[] tempArr = new int[array.Length - 1];
            if (array != null || array.Length != 0)
            {
                if (index == 0)
                {
                    for (int i = 0; i < array.Length - 1; i++)
                    {
                        if (i < array.Length - 1)
                        {
                            tempArr[i] = array[i + 1];
                        }
                        else
                        {
                            tempArr[i] = array[i];
                        }
                    }

                }
                else if (index == array.Length - 1)
                {

                    //RemoveLast(tempArr);
                    for (int i = 0; i <= array.Length - 2; i++)
                    {
                        tempArr[i] = array[i];
                    }

                }
                else
                {
                    for (int i = 0; i < index; i++)
                    {
                        tempArr[i] = array[i];
                    }

                    for (int i = index + 1; i <= array.Length - 1; i++)
                    {
                        tempArr[i - 1] = array[i];
                    }

                }

                return tempArr;
            }
            else
            {
                return array;
            }
        }

        /// <summary>
        /// Inserts a new array element at the start.
        /// </summary>
        /// <param name="array">Input array.</param>
        /// <param name="number">Number to be added.</param>
        /// <returns>A new array with element added at a given index. If an array is empty or null, returns new array with number in it.</returns>
        public static int[] InsertFirst(int[] array, int number)
        {
            // ToDo: implement.
            int[] tempArr = new int[array.Length + 1];
            if (array != null || array.Length != 0)
            {
                tempArr[0] = number;

                for (int i = 0; i <= array.Length - 1; i++)
                {
                    tempArr[i + 1] = array[i];
                }

                return tempArr;
            }
            else
            {
                array[0] = number;
                return array;
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
            // ToDo: implement.
            int[] tempArr = new int[array.Length + 1];
            if (array != null || array.Length != 0)
            {
                for (int i = 0; i < array.Length; i++)
                {
                    tempArr[i] = array[i];
                }

                tempArr[array.Length] = number;

                return tempArr;
            }
            else
            {
                array[0] = number;
                return array;
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
            // ToDo: implement.
            int[] tempArr = new int[array.Length + 1];
            if (array != null || array.Length != 0)
            {
                for (int i = 0; i < index; i++)
                {
                    tempArr[i] = array[i];
                }

                for (int i = index + 1; i < tempArr.Length; i++)
                {
                    tempArr[i] = array[i - 1];
                }

                tempArr[index] = number;

                return tempArr;
            }
            else
            {
                array[0] = number;
                return array;
            }
        }
    }
}
