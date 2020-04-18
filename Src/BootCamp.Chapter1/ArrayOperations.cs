namespace BootCamp.Chapter1
{
    public static class ArrayOperations
    {
        public static void Sort(int[] array)
        {
            if (array != null && array.Length != 0)
            {
                int t;
                for (int i = 0; i < array.Length; i++)
                {
                    for (int j = i + 1; j < array.Length; j++)
                    {
                        if (array[j] < array[i])
                        {
                            t = array[i];
                            array[i] = array[j];
                            array[j] = t;
                        }
                    }
                }
            }
        }

        public static void Reverse(int[] array)
        {
            if (array != null && array.Length != 0)
            {
                int t;
                for (int i = 0; i < array.Length / 2; i++)
                {
                    t = array[i];
                    array[i] = array[array.Length - i - 1];
                    array[array.Length - i - 1] = t;
                }

            }
        }

        public static int[] RemoveLast(int[] array)
        {
            if (array != null && array.Length != 0)
            {
                int[] updatedArray = new int[array.Length - 1];
                for (int i = 0; i < array.Length - 1; i++)
                {
                    updatedArray[i] = array[i];
                }
                return updatedArray;
            }

            return array;
        }

        public static int[] RemoveFirst(int[] array)
        {
            if (array != null && array.Length != 0)
            {
                int[] updatedArray = new int[array.Length - 1];
                for (int i = 0; i < array.Length - 1; i++)
                {
                    updatedArray[i] = array[i + 1];
                }
                return updatedArray;
            }

            return array;
        }

        public static int[] RemoveAt(int[] array, int index)
        {
            if (array != null && array.Length != 0 && index < array.Length && index >= 0)
            {
                int[] updatedArray = new int[array.Length - 1];
                int i = 0;
                int j = 0;
                while (i < array.Length)
                {
                    if (i != index)
                    {
                        updatedArray[j] = array[i];
                        j++;
                    }

                    i++;
                }

                return updatedArray;
            }

            return array;
        }

        public static int[] InsertFirst(int[] array, int number)
        {
            if (array != null && array.Length >= 1)
            {
                int[] updatedArray = new int[array.Length + 1];
                updatedArray[0] = number;

                for (int i = 1; i < updatedArray.Length; i++)
                {
                    updatedArray[i] = array[i - 1];
                }

                return updatedArray;
            }

            int[] newArray = new int[1] { number };
            return newArray;
        }


        public static int[] InsertLast(int[] array, int number)
        {
            if (array != null && array.Length >= 1)
            {
                int[] updatedArray = new int[array.Length + 1];
                updatedArray[updatedArray.Length - 1] = number;

                for (int i = updatedArray.Length - 2; i > 0; i--)
                {
                    updatedArray[i] = array[i];
                }

                return updatedArray;
            }

            int[] newArray = new int[1] { number };
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
            if (array != null && array.Length != 0 && index < array.Length && index >= 0)
            {
                int[] updatedArray = new int[array.Length + 1];
                int i = 0;
                int j = 0;
                while (i < updatedArray.Length)
                {
                    if (i != index)
                    {
                        updatedArray[j] = array[i];
                    }
                    else
                    {
                        updatedArray[j] = number;
                        i++;
                    }
                    i++;
                    j++;
                }

                return updatedArray;
            }

            int[] newArray = new int[1] { number };
            return newArray;
        }
    }
}
