namespace BootCamp.Chapter1
{
    public static class ArrayOperations
    {
        public static void Sort(int[] array)
        {
            if (array == null || array.Length == 0)
            {
                return;
            }
            int result = 0;
            for (int i = 0; i < array.Length - 1; i++)
            {
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[j] < array[i])
                    {
                        result = array[i];
                        array[i] = array[j];
                        array[j] = result;
                    }
                }
            }
        }
        public static void Reverse(int[] array)
        {
            if (array == null || array.Length == 0)
            {
                return;
            }
            int revArray = array.Length;
            for (int i = 0; i < revArray / 2; i++)
            {
                int temp = array[i];
                array[i] = array[revArray - i - 1];
                array[revArray - i - 1] = temp;
            }
        }
        public static int[] RemoveLast(int[] array)
        {
            if (array == null || array.Length == 0)
            {
                return array;
            }
            return RemoveAt(array, array.Length -1 );
        }
        public static int[] RemoveFirst(int[] array)
        {
            if (array == null || array.Length == 0)
            {
                return array;
            }
            return RemoveAt(array, 0);
        }
        public static int[] RemoveAt(int[] array, int index)
        {
            if (array == null || array.Length == 0)
            {
                return array;
            }
            if (index > array.Length - 1 || index < 0)
            {
                return array;
            }
            var array2 = new int[array.Length - 1];
            int j = 0;
            for (int i = 0; i < array.Length - 1; i++)
            {
                if (i == index)
                {
                    j++;
                }
                array2[i] = array[j];
                j++;
            }
            return array2;
        }
        public static int[] InsertFirst(int[] array, int number)
        {
            if (array == null)
            {
                int[] First = new[] { number };
                return First;
            }

            int[] First2 = InsertAt(array, number, 0);
            return First2;
        }
        public static int[] InsertLast(int[] array, int number)
        {
            if (array == null)
            {
                int[] Last1 = new[] { number };
                return Last1;
            }

            int[] Last2 = InsertAt(array, number, array.Length);
            return Last2;
        }
        public static int[] InsertAt(int[] array, int number, int index)
        {
            if (array == null)
            {
                var newArray = new int[1];
                newArray[0] = number;
                return newArray;
            }
            if (array.Length == 0 && index == 0)
            {
                var newArray = new int[1];
                newArray[0] = number;
                return newArray;
            }
            if (array.Length == 0 && index > 0 || index < 0)
            {
                return array;
            }
            var addArray = new int[array.Length + 1];
            for (int i = 0; i < addArray.Length; i++)
            {
                if (i < index)
                {
                    addArray[i] = array[i];
                }
                else if (i == index)
                {
                    addArray[i] = number;
                }
                else
                {
                    addArray[i] = array[i - 1];
                }
            }
            return addArray;
        
    }
    }
}
