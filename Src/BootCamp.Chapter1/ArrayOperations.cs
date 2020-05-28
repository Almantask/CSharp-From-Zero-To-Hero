namespace BootCamp.Chapter1
{
    public static class ArrayOperations
    {
        public static void Sort(int[] array)
        {
            if (IsNullOrEmpty(array))
            {
                return;
            }

            for (int i = 1; i < array.Length; i++)
            {
                for (int x = i; x > 0; x--)
                {
                    if (array[x] < array[x - 1])
                    {
                        int temp = array[x];
                        array[x] = array[x - 1];
                        array[x - 1] = temp;
                    } 
                    else {
                        break;
                    }
                }
            }
        }

        public static void Reverse(int[] array)
        {
            if (IsNullOrEmpty(array))
            {
                return;
            }

            for (int i = 0; i < array.Length/2; i++)
            {
                int temp = array[i];
                array[i] = array[array.Length - 1 - i];
                array[array.Length -1 - i] = temp;
            }

        }

        public static int[] RemoveLast(int[] array)
        {
            return RemoveAt(array, array.Length - 1);
        }

        public static int[] RemoveFirst(int[] array)
        {
            return RemoveAt(array, 0);
        }

        public static int[] RemoveAt(int[] array, int index)
        {
            if (IsNullOrEmpty(array) || index < 0 || index > array.Length - 1) // If Null Or Empty or OutOfBounds
            {
                return array;
            }

            int[] newArray = new int[array.Length - 1];

            for (int i = 0; i < index; i++)
            {
                newArray[i] = array[i];
            }

            for (int i = index; i < array.Length - 1; i++)
            {
                newArray[i] = array[i + 1];
            }

            return newArray;
        }

        public static int[] InsertFirst(int[] array, int number)
        {
            return InsertAt(array, number, 0);
        }

        public static int[] InsertLast(int[] array, int number)
        {
            return InsertAt(array, number, array.Length);
        }

        public static int[] InsertAt(int[] array, int number, int index)
        {
            int[] newArray;

            if (IsNullOrEmpty(array))
            {
                newArray = new int[1] { number };
            }

            else if (index < 0 || index > array.Length) //If OutOfBounds
            {
                return array;
            }

            else
            {
                newArray = new int[array.Length + 1];

                for (int i = 0; i < index; i++)
                {
                    newArray[i] = array[i];
                }

                newArray[index] = number;

                for (int i = index + 1; i < newArray.Length; i++)
                {
                    newArray[i] = array[i - 1];
                }
            }

            return newArray;
        }

        private static bool IsNullOrEmpty(int[] array)
        {
            if (array == null || array.Length == 0)
            {
                return true;
            }

            return false;
        }
    }
}
